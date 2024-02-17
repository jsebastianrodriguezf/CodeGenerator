using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace GenerarCodigo
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
            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                content.Add($"{prespace}public virtual DbSet<{file.Name}> {file.Name}s {{ get; set; }}");
            }

            return content;
        }

        private List<string> GetConfigurationConext(string prespace)
        {
            List<string> content = [];
            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                content.Add($"{prespace}modelBuilder.ApplyConfiguration(new {file.Name}Configuration());");
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

            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                content = [
                    "using Microsoft.EntityFrameworkCore;",
                    "using Microsoft.EntityFrameworkCore.Metadata.Builders;",
                    "using SAMMAI.DataBase.Repository.Entities;",
                    "",
                    "namespace SAMMAI.DataBase.Repository.Configurations;",
                    "",
                    $"public class {file.Name}Configuration : IEntityTypeConfiguration<{file.Name}>",
                    "{",
                    $"    public void Configure(EntityTypeBuilder<{file.Name}> builder)",
                    "    {"
                    ];

                content.AddRange(ExtractConfiguration(file.Name, template, startSearchIndex));

                content.Add("    }");
                content.Add("}");

                GenerateFile("Configurations", $"{file.Name}Configuration.cs", content);
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

                        content.Add(textLine.Replace("entity", "builder"));
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

            foreach (FileModel file in _filesModel.Where(x => x.Name != _contextName))
            {
                List<string> template = [.. File.ReadAllLines(file.Path)];

                contentObject = [
                    "namespace SAMMAI.Transverse.Models.Objects;",
                    "",
                    $"public class {file.Name}Object",
                    "{"
                ];

                (int, List<string>) resp = ExtractEntityObject(template);

                contentObject.AddRange(resp.Item2);
                contentObject.Add("}");

                GenerateFile("Objects", $"{file.Name}Object.cs", contentObject);

                contentEntity = [
                    "namespace SAMMAI.DataBase.Repository.Entities;",
                    "",
                    $"public partial class {file.Name} : {file.Name}Object",
                    "{",
                ];

                contentEntity.AddRange(ExtractEntityEntity(resp.Item1, template));
                contentEntity.Add("}");

                GenerateFile("Entities", $"{file.Name}.cs", contentEntity);
            }
        }

        public (int, List<string>) ExtractEntityObject(List<string> template)
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
                    if (line.Contains("public string Eid { get; set; } = null!;") || line.Contains("public string Uid { get; set; } = null!;"))
                        content.Add(line.Replace("string", "string?").Replace(" = null!;", string.Empty));
                    else
                        content.Add(line);
            }

            return (i, content);
        }

        public List<string> ExtractEntityEntity(int startIndex, List<string> template)
        {
            List<string> content = [];

            for (int i = startIndex; i < template.Count; i++)
            {
                string linea = template[i];
                if (linea.StartsWith("}"))
                    break;

                if (linea != "")
                    content.Add(linea);
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
