using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator.BLL
{

    public class DatabaseGenerator
    {
        private readonly string _contextName;
        private readonly string _rootPath;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;
        private readonly string _destinyPath;

        public DatabaseGenerator(
            string conextName,
            string rootPath,
            string destityPath)
        {
            _contextName = conextName;
            _rootPath = rootPath;
            _destinyPath = destityPath;
            _files = [.. Directory.GetFiles(_rootPath)];
            _filesModel = Utilities.GetFilesModel(_files);
            Utilities.RegenerateDirectory(_destinyPath);
        }

        public string Generate()
        {
            try
            {
                GenerateContext();
                GenerateConfiguration();
                GenerateEntities();

                return "Files was generated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #region GenerateContext
        public void GenerateContext()
        {
            List<string> contenidoObject = [
                "using Microsoft.EntityFrameworkCore;",
                "using SAMMAI.DataBase.Repository.Configurations;",
                "using SAMMAI.DataBase.Repository.Entities;",
                "",
                "namespace SAMMAI.DataBase.Repository.Context;",
                "",
                $"public class {_contextName} : DbContext",
                "{",
                $"    public {_contextName}() " + "{ }",
                "",
                $"    public {_contextName}(DbContextOptions<{_contextName}> options)",
                "        : base(options) { }",
                "",
                "    #region DBSet"
            ];

            contenidoObject.AddRange(GetDBSetConext("    "));

            contenidoObject.AddRange([
                "    #endregion",
                "",
                "    protected override void OnModelCreating(ModelBuilder modelBuilder)",
                "    {"
                ]);

            contenidoObject.AddRange(GetConfigurationConext("        "));

            contenidoObject.AddRange([
                "    }",
                "}",
            ]);

            GenerateFile("Context", $"{_contextName}.cs", contenidoObject);
        }

        private List<string> GetDBSetConext(string prespace)
        {
            List<string> content = [];
            string name;

            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                name = Utilities.GetRealName(file.Name);
                content.Add($"{prespace}public virtual DbSet<{name}> {name}s {{ get; set; }}");
            }

            return content;
        }

        private List<string> GetConfigurationConext(string prespace)
        {
            List<string> content = [];
            string name;

            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                name = Utilities.GetRealName(file.Name);
                content.Add($"{prespace}modelBuilder.ApplyConfiguration(new {name}Configuration());");
            }

            return content;
        }
        #endregion

        #region GenerateConfiguration
        public void GenerateConfiguration()
        {
            List<string> content;
            List<string> template = [.. File.ReadAllLines(Path.Combine(_rootPath, $"{_contextName}.cs"))];
            int startSearchIndex = template.FindIndex(x => x == "    protected override void OnModelCreating(ModelBuilder modelBuilder)");
            string classObjectName;

            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                classObjectName = Utilities.GetRealName(file.Name);

                content = [
                    "using Microsoft.EntityFrameworkCore;",
                    "using Microsoft.EntityFrameworkCore.Metadata.Builders;",
                    "using SAMMAI.DataBase.Repository.Entities;",
                    "",
                    "namespace SAMMAI.DataBase.Repository.Configurations;",
                    "",
                    $"public class {classObjectName}Configuration : IEntityTypeConfiguration<{classObjectName}>",
                    "{",
                    $"    public void Configure(EntityTypeBuilder<{classObjectName}> builder)",
                    "    {"
                    ];

                content.AddRange(ExtractConfiguration(file.Name, template, startSearchIndex));

                content.Add("    }");
                content.Add("}");

                GenerateFile("Configurations", $"{classObjectName}Configuration.cs", content);
            }
        }

        public List<string> ExtractConfiguration(string className, List<string> template, int startSearchIndex)
        {
            string textLine;
            List<string> content = [];
            const string prespace = "    ";


            for (int i = startSearchIndex; i < template.Count; i++)
            {
                textLine = template[i];

                if (textLine.Contains($"modelBuilder.Entity<{className}>(entity =>"))
                {
                    for (int j = i + 2; !template[j].Contains("});"); j++)
                    {
                        textLine = template[j];
                        if (textLine.Length >= prespace.Length)
                            textLine = textLine[prespace.Length..];

                        textLine = textLine.Replace("entity", "builder");

                        if (textLine.Contains($"builder.Property(e => e.{className}1)"))
                            textLine = textLine.Replace($"builder.Property(e => e.{className}1)", $"builder.Property(e => e.{className})");

                        content.Add(textLine);
                    }

                    return content;
                }
            }

            return content;
        }
        #endregion

        #region GenerateEntities
        public void GenerateEntities()
        {
            List<string> contentObject;
            List<string> contentEntity;
            string classObjectName;

            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                List<string> template = [.. File.ReadAllLines(file.Path)];
                classObjectName = Utilities.GetRealName(file.Name);

                contentObject = [
                    "namespace SAMMAI.Transverse.Models.Objects;",
                    "",
                    $"public class {classObjectName}Object",
                    "{"
                ];

                (int, List<string>) resp = ExtractEntityObject(template, classObjectName);

                contentObject.AddRange(resp.Item2);
                contentObject.Add("}");

                GenerateFile("Objects", $"{classObjectName}Object.cs", contentObject);

                contentEntity = [
                    "namespace SAMMAI.DataBase.Repository.Entities;",
                    "",
                    $"public partial class {classObjectName} : {classObjectName}Object",
                    "{",
                ];

                contentEntity.AddRange(ExtractEntityEntity(resp.Item1, template));
                contentEntity.Add("}");

                GenerateFile("Entities", $"{classObjectName}.cs", contentEntity);
            }
        }

        public (int, List<string>) ExtractEntityObject(List<string> template, string className)
        {
            const int indexStart = 7;
            List<string> content = [];
            int i = indexStart;

            for (; i < template.Count; i++)
            {
                string line = template[i];
                if (line.Contains("public virtual ") || line.StartsWith("}"))
                    break;

                if (line != "")
                {
                    if (line.Contains("public string Eid { get; set; } = null!;") || line.Contains("public string Uid { get; set; } = null!;"))
                        line = line.Replace("string", "string?").Replace(" = null!;", string.Empty);

                    if (line.Contains($" {className}1 {{ get; set; }}"))
                        line = line.Replace($" {className}1 {{ get; set; }}", $" {className} {{ get; set; }}");

                    content.Add(line);
                }
            }

            return (i, content);
        }

        public List<string> ExtractEntityEntity(int startIndex, List<string> template)
        {
            List<string> content = [];
            const string umObj = "um>";
            const string umObjReplace = "a>";
            const string umClass = "um ";
            const string umClassReplace = "a ";

            for (int i = startIndex; i < template.Count; i++)
            {
                string linea = template[i];
                if (linea.StartsWith("}"))
                    break;

                if (linea != "")
                {
                    if (linea.Contains(umObj))
                        linea = linea.Replace(umObj, umObjReplace);

                    if (linea.Contains(umClass))
                        linea = linea.Replace(umClass, umClassReplace);

                    content.Add(linea);
                }
            }

            return content;
        }
        #endregion

        #region Utilities
        private void GenerateFile(string directory, string file, List<string> content)
            => Utilities.GenerateFile(_destinyPath, directory, file, content);
        #endregion
    }
}
