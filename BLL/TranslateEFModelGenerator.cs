using CodeGenerator.External;
using CodeGenerator.Helper;
using CodeGenerator.Models;
using static CodeGenerator.Constants.BaseConstants;

namespace CodeGenerator.BLL
{
    public class TranslateEFModelGenerator
    {
        private readonly string _contextName;
        private readonly string _rootPath;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;
        private readonly string _destinyPath;
        private readonly TranstaleService _transtaleService;

        public TranslateEFModelGenerator(
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
            _transtaleService = new TranstaleService(Languages.Spanish, Languages.English);
        }

        public string Generate()
        {
            try
            {
                GenerateContextFile();
                GenerateEntitiesFiles();

                return "Files was generated successfully";
            }
            catch
            {
                throw;
            }
        }

        public void GenerateContextFile()
        {
            List<string> template;
            List<string> contentTranslated;
            string translatedLine;
            string[] contentTranslated2;
            List<string> additionalProperty;
            int indexAdditionalProperty;



            template = [.. File.ReadAllLines(Path.Combine(_rootPath, $"{_contextName}.cs"))];
            contentTranslated = [];
            contentTranslated2 = new string[template.Count];

            for (int i = 0; i < template.Count; i++)
            {
                indexAdditionalProperty = i;

                additionalProperty = AddPropertyToProperty(template[i], template, ref indexAdditionalProperty);
                if (additionalProperty.Count > 0 && indexAdditionalProperty >= i)
                {
                    template[indexAdditionalProperty] = template[indexAdditionalProperty][..^1];
                    template.InsertRange(indexAdditionalProperty + 1, additionalProperty);
                }

                string line = template[i];
                translatedLine = TranslateContextLine(line);

                contentTranslated.Add(translatedLine);
            }


            //try
            //{
            //    Parallel.For(0, template.Count, i =>
            //    {
            //        try
            //        {
            //            string line = template[i];
            //            translatedLine = TranslateContextLine(line);
            //            contentTranslated2[i] = translatedLine;
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine($"Exception on iteration {i}: {ex.Message}");
            //        }
            //    });
            //}
            //catch (AggregateException ae)
            //{
            //    foreach (var ex in ae.InnerExceptions)
            //    {
            //        Console.WriteLine($"Caught exception: {ex.Message}");
            //    }
            //}

            GenerateFile("", $"{_contextName}.cs", [.. contentTranslated]);
        }

        public void GenerateEntitiesFiles()
        {
            List<string> template;
            List<string> contentTranslated;
            string translatedLine;

            foreach (FileModel fileModel in _filesModel.Where(x => x.Name != _contextName))
            {
                template = [.. File.ReadAllLines(fileModel.Path)];
                contentTranslated = [];

                foreach (string line in template)
                {
                    translatedLine = TranslateClassName(line);
                    translatedLine = TranslateProperties(translatedLine);

                    contentTranslated.Add(translatedLine);
                }

                GenerateFile("", $"{Translate(fileModel.Name)}.cs", contentTranslated);
            }
        }

        #region private

        #region GenerateContextFile

        private string TranslateContextLine(string line)
        {
            line = TranslateDbSetLine(line);
            line = TranslateOnModelCreatingLine(line);

            return line;
        }

        private string TranslateDbSetLine(string line)
        {
            int startIndex;
            int endIndex;
            string className;
            string classNameTranslated;

            const string startLine = "    public virtual DbSet<";
            const string endLine = " { get; set; }";

            if (line.StartsWith(startLine) && line.EndsWith(endLine))
            {
                startIndex = startLine.Length;
                endIndex = line.IndexOf('>');

                className = line[startIndex..endIndex];
                classNameTranslated = Translate(className);

                line = $"    public virtual DbSet<{classNameTranslated}> {classNameTranslated} {{ get; set; }}";
            }

            return line;
        }

        private string TranslateOnModelCreatingLine(string line)
        {
            line = TranslateEntityConfig(line);
            line = TranslatePropertyConfig(line);
            line = TranslateMultiPropertyConfig(line);
            line = TranslateForeignPropertyTypeConfig(line);
            line = TranslateForeignPropertyConfig(line);
            line = TranslateForeignEntityConfig(line);

            return line;
        }

        private string TranslateEntityConfig(string line)
        {
            int startIndex;
            int endIndex;
            string entity;
            string entityTranslated;

            const string startLine = "        modelBuilder.Entity<";
            const string endLine = ">(entity =>";

            if (line.StartsWith(startLine) && line.EndsWith(endLine))
            {
                startIndex = startLine.Length;
                endIndex = line.IndexOf('>');

                entity = line[startIndex..endIndex];
                entityTranslated = Translate(entity);

                line = $"        modelBuilder.Entity<{entityTranslated}>(entity =>";
            }

            return line;
        }

        private List<string> AddPropertyToProperty(string line, List<string> template, ref int index)
        {
            int startIndex;
            int endIndex;
            string property;
            bool containsHasColumnName;
            List<string> content = [];

            const string startLine = "entity.Property(e => e.";
            const string endProperty = ";";
            const string hasColumnName = "HasColumnName";

            if (line.Contains(startLine))
            {
                startIndex = line.IndexOf(startLine) + startLine.Length;
                endIndex = line.IndexOf(',');

                if (endIndex == -1)
                    endIndex = line.IndexOf(')');

                property = line[startIndex..endIndex];

                for (int i = index; i < template.Count; i++)
                {
                    string propertyLine = template[i];

                    containsHasColumnName = propertyLine.Contains(hasColumnName);

                    if (propertyLine.Contains(endProperty) && !containsHasColumnName)
                    {
                        content.AddRange([
                            $"                .{hasColumnName}(\"{property}\");"
                        ]);

                        index = i;
                        return content;
                    }

                    if (containsHasColumnName)
                        break;
                }
            }

            index = -1;
            return [];
        }

        private string TranslatePropertyConfig(string line)
        {
            int startIndex;
            int endIndex;
            string property;
            string propertyTranslated;

            const string startLine = "(e => e.";

            if (line.Contains(startLine))
            {
                startIndex = line.IndexOf(startLine) + startLine.Length;
                endIndex = line.IndexOf(',');

                if (endIndex == -1)
                    endIndex = line.IndexOf(')');

                property = line[startIndex..endIndex];
                propertyTranslated = Translate(property);

                line = line.Replace(startLine + property, startLine + propertyTranslated);
            }

            return line;
        }

        private string TranslateMultiPropertyConfig(string line)
        {
            int startIndex;
            int endIndex;
            List<string> properties;
            string propertyTranslated;

            const string startLine = "(e => new {";
            const string endLine = " }";
            const string splitString = ",";
            const string lamda = " e.";

            if (line.Contains(startLine))
            {
                startIndex = line.IndexOf(startLine) + startLine.Length;
                endIndex = line.IndexOf(endLine);

                properties = [.. line[startIndex..endIndex].Replace(lamda, "").Split(splitString)];
                foreach (string property in properties)
                {
                    propertyTranslated = Translate(property);
                    line = line.Replace(lamda + property, lamda + propertyTranslated);
                }
            }

            return line;
        }

        private string TranslateForeignPropertyConfig(string line)
        {
            int startIndex;
            int endIndex;
            string property;
            string propertyTranslated;
            string endKey;

            const string startKey = "(d => d.";
            const string navigation = ")";//"Navigation)";

            if (line.Contains(startKey))
            {
                endKey = line.Contains(navigation) ? navigation : ")";

                startIndex = line.IndexOf(startKey) + startKey.Length;
                endIndex = line.IndexOf(endKey);

                property = line[startIndex..endIndex];
                propertyTranslated = Translate(property);

                line = line.Replace(startKey + property + endKey, startKey + propertyTranslated + endKey);
            }

            return line;
        }

        private string TranslateForeignPropertyTypeConfig(string line)
        {
            int startIndex;
            int endIndex;
            string property;
            string propertyTranslated;

            const string startKey = "<";
            const string endKey = ">(d => d.";

            if (line.Contains(startKey) && line.Contains(endKey))
            {
                startIndex = line.IndexOf(startKey) + startKey.Length;
                endIndex = line.IndexOf(endKey);

                property = line[startIndex..endIndex];
                propertyTranslated = Translate(property);

                line = line.Replace(startKey + property + endKey, startKey + propertyTranslated + endKey);
            }

            return line;
        }

        private string TranslateForeignEntityConfig(string line)
        {
            int startIndex;
            int endIndex;
            string property;
            string propertyTranslated;

            const string startKey = "(p => p.";

            if (line.Contains(startKey))
            {
                startIndex = line.IndexOf(startKey) + startKey.Length;
                endIndex = line.LastIndexOf(')');

                property = line[startIndex..endIndex];
                propertyTranslated = Translate(property);

                line = line.Replace(startKey + property, startKey + propertyTranslated);
            }

            return line;
        }

        #endregion

        #region GenerateEntitiesFiles

        private string TranslateClassName(string line)
        {
            int startIndex;
            int endIndex;
            string className;
            string classNameTranslated;

            const string startLine = "public partial class ";

            if (line.StartsWith(startLine))
            {
                startIndex = startLine.Length;
                endIndex = line.Length;

                className = line[startIndex..endIndex];
                classNameTranslated = Translate(className);

                line = $"public partial class {classNameTranslated}";
            }

            return line;
        }

        private string TranslateProperties(string line)
        {
            line = TranslateBasicProperties(line);
            line = TranslateVirtualProperties(line);

            return line;
        }

        private string TranslateBasicProperties(string line)
        {
            string property;
            string propertyTranslated;

            const string startLine = "    public ";
            const string getset = " { get; set; }";
            const string virtualProperty = "virtual";

            if (line.StartsWith(startLine) && !line.Contains(virtualProperty))
            {
                property = line.Split(" ")[6];

                propertyTranslated = Translate(property);

                line = line.Replace(property + getset, propertyTranslated + getset);
            }

            return line;
        }

        private string TranslateVirtualProperties(string line)
        {
            const string startLine = "    public virtual ";

            if (line.StartsWith(startLine))
            {
                line = TranslateVirtualBasic(line);
                line = TranslateVirtualICollection(line);
                line = TranslateVirtualICollectionNavigation(line);
                line = TranslateVirtualICollectionInverseNavigation(line);
            }

            return line;
        }

        public string TranslateVirtualBasic(string line)
        {
            string property;
            string propertyTranslated;
            string[] lineList;

            const string notStartLine = "    public virtual ICollection<";
            const string startLine = "    public virtual ";

            if (line.Contains(startLine) && !line.StartsWith(notStartLine))
            {
                lineList = line.Split(" ");
                property = lineList[6];
                propertyTranslated = Translate(property);
                lineList[6] = propertyTranslated;

                property = lineList[7];
                propertyTranslated = Translate(property);
                lineList[7] = propertyTranslated;

                line = string.Join(" ", lineList);
            }

            return line;
        }

        public string TranslateVirtualICollection(string line)
        {
            int startIndex;
            int endIndex;
            string entity;
            string entityTranslated;

            const string startLine = "    public virtual ICollection<";
            const string inverse = "Inverse";
            const string navigation = "Navigation";
            const string getset = " { get; set; }";

            if (line.StartsWith(startLine) && !line.Contains(inverse) && !line.Contains(navigation))
            {
                startIndex = startLine.Length;
                endIndex = line.IndexOf('>');

                entity = line[startIndex..endIndex];
                entityTranslated = Translate(entity);

                line = line.Replace($"<{entity}>", $"<{entityTranslated}>");

                startIndex = line.IndexOf('>') + 2;
                endIndex = line.IndexOf(getset);

                entity = line[startIndex..endIndex];
                entityTranslated = Translate(entity);

                line = line.Replace($"> {entity}{getset}", $"> {entityTranslated}{getset}");
            }

            return line;
        }

        public string TranslateVirtualICollectionNavigation(string line)
        {
            int startIndex;
            int endIndex;
            string entity;
            string entityTranslated;
            string propertyStartLine;
            string propertyEndLine;

            const string startLine = "    public virtual ICollection<";
            const string inverse = "Inverse";
            const string navigation = "Navigation";
            const string getset = "{ get; set; }";

            if (line.StartsWith(startLine) && !line.Contains(inverse) && line.Contains(navigation))
            {
                //entity
                startIndex = startLine.Length;
                endIndex = line.IndexOf('>');

                entity = line[startIndex..endIndex];
                entityTranslated = Translate(entity);

                line = line.Replace($"<{entity}>", $"<{entityTranslated}>");

                //property
                propertyStartLine = $"{startLine}{entityTranslated}> ";
                propertyEndLine = $" {getset}";

                startIndex = propertyStartLine.Length;
                endIndex = line.IndexOf(propertyEndLine);

                entity = line[startIndex..endIndex];
                entityTranslated = Translate(entity);

                line = line.Replace(propertyStartLine + entity + propertyEndLine, propertyStartLine + entityTranslated + propertyEndLine);
            }

            return line;
        }

        public string TranslateVirtualICollectionInverseNavigation(string line)
        {
            int startIndex;
            int endIndex;
            string entity;
            string entityTranslated;
            string propertyStartLine;
            string propertyEndLine;

            const string startLine = "    public virtual ICollection<";
            const string inverse = "Inverse";
            const string navigation = "Navigation";
            const string getset = "{ get; set; }";

            if (line.StartsWith(startLine) && line.Contains(inverse) && line.Contains(navigation))
            {
                //entity
                startIndex = startLine.Length;
                endIndex = line.IndexOf('>');

                entity = line[startIndex..endIndex];
                entityTranslated = Translate(entity);

                line = line.Replace($"<{entity}>", $"<{entityTranslated}>");

                //property
                propertyStartLine = $"{startLine}{entityTranslated}> ";
                propertyEndLine = $" {getset}";

                startIndex = propertyStartLine.Length;
                endIndex = line.IndexOf(propertyEndLine);

                entity = line[startIndex..endIndex];
                entityTranslated = Translate(entity);

                line = line.Replace(propertyStartLine + entity + propertyEndLine, propertyStartLine + entityTranslated + propertyEndLine);
            }

            return line;
        }

        #endregion

        private string Translate(string text)
            => _transtaleService.Translate(text).Result;

        private void GenerateFile(string directory, string file, List<string> content)
          => Utilities.GenerateFile(_destinyPath, directory, file, content);

        #endregion
    }
}
