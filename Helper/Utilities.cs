using CodeGenerator.Models;
using System.Text;
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
    }
}
