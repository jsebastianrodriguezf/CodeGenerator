using CodeGenerator.Models;
using System.Text;
using System.Text.Json;
namespace CodeGenerator.Helper
{
    public class Utilities
    {
        public static void RegenerateDirectory(string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);

            Directory.CreateDirectory(path);
        }

        public static List<FileModel> GetFilesModel(List<string> files)
        {
            return [
                .. files.
                Select(x =>
                {
                    List<string> file = [.. x.Split("\\").Last().Split(".")];

                    return new FileModel()
                    {
                        Path = x,
                        Name = string.Join(".", file.GetRange(0, file.Count - 1)),
                        Extension = file.Last()
                    };
                }).
                OrderBy(x => x.Name),
            ];
        }

        public static List<DirectoryModel> GetDirectoriesModel(List<string> directories)
        {
            return [
               .. directories.
                Select(x =>
                {
                    List<string> directory = [.. x.Split("\\")];

                    return new DirectoryModel()
                    {
                        Path = x,
                        Name = directory.Last(),
                        Files = []
                    };
                }).
                OrderBy(x => x.Name),
            ];
        }

        public static void GenerateFile(string destinyPath, string directory, string file, List<string> content)
        {
            string pathDirectory;
            string pathFile;

            pathDirectory = Path.Combine(destinyPath, directory);
            pathFile = Path.Combine(pathDirectory, file);

            if (!Directory.Exists(pathDirectory))
                Directory.CreateDirectory(pathDirectory);

            if (File.Exists(pathFile))
                File.Delete(pathFile);

            File.WriteAllLines(pathFile, content);
        }

        public static string GetRealName(string value)
        {
            const string Um = "um";
            const string UmReplace = "a";

            if (value.EndsWith(Um))
                value = value[..(value.Length - (UmReplace.Length + 1))] + UmReplace;

            return value;
        }

        public static string ToKebabCase(string inputString)
        {
            StringBuilder kebabCaseString = new StringBuilder();
            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];
                if (Char.IsUpper(currentChar))
                {
                    if (i != 0)
                    {
                        kebabCaseString.Append('-');
                    }
                    kebabCaseString.Append(Char.ToLower(currentChar));
                }
                else if (currentChar == '_')
                {
                    kebabCaseString.Append('-');
                }
                else
                {
                    kebabCaseString.Append(currentChar);
                }
            }
            return kebabCaseString.ToString();
        }

        public static List<string> GetCustomCode(FileModel? fileModel, string regionName)
        {
            List<string> customLines;
            string startKey = "#region Custom " + regionName;
            const string endKey = "#endregion";

            customLines = [];

            if (fileModel is null)
                return [""];

            List<string> template = [.. File.ReadAllLines(fileModel.Path)];

            for (int i = 0; i < template.Count; i++)
            {
                string line = template[i];
                if (line.Contains(startKey))
                {
                    for (i = i + 1; i < template.Count; i++)
                    {
                        line = template[i];
                        if (line.Contains(endKey))
                            i = template.Count;
                        else
                            customLines.Add(line);
                    }
                }
            }

            return customLines.Count > 0 ? customLines : [""];
        }

        public static List<string> GetNamespaces(FileModel? fileModel, List<string> defaultNamespaces)
        {
            List<string> content;

            content = GetNamespaces(fileModel);

            if (content.Count == 0)
                content = defaultNamespaces;
            else
            {
                for (int i = 0; i < defaultNamespaces.Count; i++)
                {
                    if (!content.Any(x => x.Equals(defaultNamespaces[i])))
                    {
                        content.Insert(i, defaultNamespaces[i]);
                    }
                }
            }

            return content;
        }

        private static List<string> GetNamespaces(FileModel? fileModel)
        {
            List<string> template;
            List<string> customLines;
            const string namespaceKey = "namespace";

            if (fileModel is null) return [];

            template = [.. File.ReadAllLines(fileModel.Path)];
            customLines = [];

            for (int i = 0; i < template.Count; i++)
            {
                string line = template[i];

                if (template[i + 1].StartsWith(namespaceKey))
                    i = template.Count;
                else
                    customLines.Add(line);
            }

            return customLines;
        }

        public static List<string> GetConstructor(FileModel? fileModel, string constructorMethod, List<string> defaultProperties, List<string> defaultParameters, List<string> defaultContent)
        {
            List<string> content;
            List<string> defaultContructor;
            string openBrackets = "        {";
            string closeBrackets = "        }";
            int lastBracket;
            int indexContent;

            defaultContructor = [];
            defaultContructor.AddRange(defaultProperties);
            defaultContructor.Add("");
            defaultContructor.Add(constructorMethod);
            defaultContructor.AddRange(defaultParameters);

            lastBracket = (defaultContructor[^1].Contains(':')) ? 2 : 1;

            defaultContructor[^lastBracket] = defaultContructor[^lastBracket].Replace(',', ')');
            defaultContructor.Add(openBrackets);
            defaultContructor.AddRange(defaultContent);
            defaultContructor.Add(closeBrackets);

            content = GetConstructor(fileModel);

            if (content.Count == 0)
                content = defaultContructor;
            else
            {
                for (int i = 0; i < defaultProperties.Count; i++)
                {
                    if (!content.Any(x => x.Equals(defaultProperties[i])))
                    {
                        content.Insert(i, defaultProperties[i]);

                        int index = content.IndexOf(constructorMethod);
                        content.Insert(i + 1 + index, defaultParameters[i]);

                        index = content.IndexOf(openBrackets);
                        content.Insert(i + 1 + index, defaultContent[i]);
                    }
                }
            }

            //quitar los espacios
            indexContent = content.FindIndex(x => x.TrimStart().StartsWith("public"));
            if (indexContent > 3 && string.IsNullOrWhiteSpace(content[indexContent - 2]))
                content.RemoveAt(indexContent - 2);

            indexContent = content.FindIndex(x => x.TrimStart().StartsWith(':'));
            if (indexContent > 3 && string.IsNullOrWhiteSpace(content[indexContent - 1]))
                content.RemoveAt(indexContent - 1);

            indexContent = content.FindIndex(x => x.TrimStart().StartsWith('}'));
            if (indexContent > 3 && string.IsNullOrWhiteSpace(content[indexContent - 1]))
                content.RemoveAt(indexContent - 1);


            return content;
        }

        private static List<string> GetConstructor(FileModel? fileModel)
        {
            List<string> template;
            List<string> customLines;
            string startKey = "    public class";
            const string endKey = "        #region Base";

            if (fileModel is null) return [];

            template = [.. File.ReadAllLines(fileModel.Path)];
            customLines = [];

            for (int i = 0; i < template.Count; i++)
            {
                string line = template[i];
                if (line.Contains(startKey))
                {
                    for (i = i + 2; i < template.Count; i++)
                    {
                        line = template[i];
                        if (line.Contains(endKey))
                        {
                            customLines.RemoveAt(customLines.Count - 1);
                            i = template.Count;
                        }
                        else
                            customLines.Add(line);
                    }
                }
            }

            return customLines;
        }

        public static T MapJsonFile<T>(string path)
        {
            string jsonString;
            T json;

            jsonString = File.ReadAllText(path);
            json = JsonSerializer.Deserialize<T>(jsonString, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            }) ??
                throw new ArgumentNullException(nameof(MapJsonFile));

            return json;
        }

        public static bool IsNotBlackList(string line)
        {
            return
                line.Contains("public ") && line.Contains(" { get; set; }") &&
                !line.Contains(" Uid { get; set; }") &&
                !line.Contains(" Eid { get; set; }") &&
                !line.Contains(" IdUsuarioModifico { get; set; }") &&
                !line.Contains(" IdUsuarioCreo { get; set; }") &&
                !line.Contains(" FechaModificacion { get; set; }") &&
                !line.Contains(" FechaCreacion { get; set; }") &&
                !line.Contains(" Active { get; set; }") &&
                !line.Contains(" public byte[]") &&
                !line.Contains(" public string? Clave { get; set; }") &&
                !line.Contains(" Multiempresa { get; set; }") &&
                !line.Contains(" IdUserModifier { get; set; }") &&
                !line.Contains(" IdUserCreator { get; set; }") &&
                !line.Contains(" DateModification { get; set; }") &&
                !line.Contains(" DateCreation { get; set; }") &&
                !line.Contains(" public byte[]") &&
                !line.Contains(" public string? Password { get; set; }") &&
                !line.Contains(" Multicompany { get; set; }");
        }
    }
}
