using CodeGenerator.Models;
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
                        Name = file.First(),
                        Extension = file.Last()
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
    }
}
