using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator.BLL
{
    public class FolderTableGenerator
    {
        private readonly string _rootPath;
        private readonly string _configRootPath;
        private readonly string _destinyPath;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;

        public FolderTableGenerator(
            string rootPath,
            string configRootPath,
            string destityPath)
        {
            _rootPath = rootPath;
            _configRootPath = configRootPath;
            _destinyPath = destityPath;
            _files = [.. Directory.GetFiles(_configRootPath)];
            _filesModel = Utilities.GetFilesModel(_files);
            Utilities.RegenerateDirectory(_destinyPath);
        }

        public string GenerateFolders()
        {
            foreach (FileModel fileModel in _filesModel)
            {
                GenerateFolder(fileModel);
            }

            return "Ok";
        }

        public string GenerateFolder(FileModel fileModel)
        {
            string tableName;
            string folderRoot;
            string destinyFolderRoot;
            List<string> template;
            bool tableFolderExists;

            const string ddlFolder = "DDL";
            const string dmlFolder = "DML";

            template = [.. File.ReadAllLines(fileModel.Path)];
            tableName = ExtractTableName(template);

            folderRoot = Path.Combine(_rootPath, tableName);
            destinyFolderRoot = Path.Combine(_destinyPath, tableName);

            tableFolderExists = Directory.Exists(folderRoot);

            if (!tableFolderExists)
                Directory.CreateDirectory(destinyFolderRoot);

            CreateSubFolder(folderRoot, destinyFolderRoot, ddlFolder, tableFolderExists);
            CreateSubFolder(folderRoot, destinyFolderRoot, dmlFolder, tableFolderExists);

            return folderRoot;
        }

        private string ExtractTableName(List<string> template)
        {
            const int indexStart = 0;
            List<string> content = [];
            int i = indexStart;
            string tableName = "NoName";

            for (; i < template.Count; i++)
            {
                string line = template[i];

                if (line.Contains("builder.ToTable(\"") && line.EndsWith("\");"))
                {
                    int start = line.IndexOf("\"", 0) + 1;
                    int end = line.IndexOf("\"", start);
                    if (start < end)
                        tableName = line[start..end];

                    break;
                }
            }

            return tableName;
        }

        private void CreateSubFolder(string mainFolderRoot, string destinyFolderRoot, string folderName, bool tableFolderExists)
        {
            string[] directories;

            if (!tableFolderExists)
            {
                Directory.CreateDirectory(Path.Combine(destinyFolderRoot, folderName));
                return;
            }

            directories = Directory.GetDirectories(mainFolderRoot, folderName, SearchOption.AllDirectories);

            if (directories.FirstOrDefault(x => x.Equals(Path.Combine(mainFolderRoot, folderName))) is null)
                Directory.CreateDirectory(Path.Combine(destinyFolderRoot, folderName));
        }
    }
}
