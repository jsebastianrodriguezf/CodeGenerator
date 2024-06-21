using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator.BLL
{
    public class AlterTableGenerator
    {
        private readonly string _tablesRootPath;
        private readonly string _spsRootPath;
        private readonly string _destinyPath;
        private readonly List<string> _spsFiles;
        private readonly List<DirectoryModel> _spsDirectoriesModel;

        const string ddlFolder = "DDL";
        const string dmlFolder = "DML";
        const string alterFile = "Alter.sql";

        public AlterTableGenerator(
            string tablesRootPath,
            string spsRootPath,
            string destityPath)
        {
            _tablesRootPath = tablesRootPath;
            _spsRootPath = spsRootPath;
            _destinyPath = destityPath;
            _spsFiles = [.. Directory.GetDirectories(_spsRootPath)];
            _spsDirectoriesModel = Utilities.GetDirectoriesModel(_spsFiles);

            Utilities.RegenerateDirectory(_destinyPath);
        }

        public string GenerateAlterScripts()
        {
            foreach (DirectoryModel spDirectory in _spsDirectoriesModel.Where(x => !x.Name.Equals("0_custom")))
            {
                GenerateAlterScript(spDirectory);
            }

            return "Ok";
        }

        public string GenerateUpdateScript()
        {
            foreach (DirectoryModel spDirectory in _spsDirectoriesModel.Where(x => !x.Name.Equals("0_custom")))
            {
                GenerateUpdateScript(spDirectory);
            }

            return "Ok";
        }

        public void GenerateUpdateScript(DirectoryModel spDirectory)
        {
            string tableName;
            string destinyFolderRoot;
            List<string> content;
            bool destinyTableFolderExists;

            tableName = spDirectory.Name;
            destinyFolderRoot = Path.Combine(Path.Combine(_destinyPath, tableName, ddlFolder));
            destinyTableFolderExists = Directory.Exists(destinyFolderRoot);

            if (!destinyTableFolderExists)
                Directory.CreateDirectory(destinyFolderRoot);

            content = [
                $""
            ];

            //GenerateFile(destinyFolderRoot, alterFile, content);
        }

        public void GenerateAlterScript(DirectoryModel spDirectory)
        {
            string tableName;
            string destinyFolderRoot;
            List<string> content;
            bool destinyTableFolderExists;

            tableName = spDirectory.Name;
            destinyFolderRoot = Path.Combine(Path.Combine(_destinyPath, tableName, ddlFolder));
            destinyTableFolderExists = Directory.Exists(destinyFolderRoot);

            if (!destinyTableFolderExists)
                Directory.CreateDirectory(destinyFolderRoot);

            content = GetAlterContent(tableName);

            if (!string.IsNullOrWhiteSpace(content.LastOrDefault()))
                content.Add(string.Empty);

            content.AddRange(GetCmmColumnScript(tableName, content));

            GenerateFile(destinyFolderRoot, alterFile, content);
        }

        private List<string> GetAlterContent(string tableName)
        {
            string rootFile;

            rootFile = Path.Combine(_tablesRootPath, tableName, ddlFolder, alterFile);

            if (!File.Exists(rootFile))
                return [];

            return [.. File.ReadAllLines(rootFile)];
        }

        public List<string> GetCmmColumnScript(string tableName, List<string> template)
        {
            List<string> content;
            string newColumnScript;

            newColumnScript = $"ALTER TABLE [{tableName}] ADD [cmm] VARCHAR(300)";

            if (template.Any(x => x.Contains(newColumnScript.ToLower(), StringComparison.CurrentCultureIgnoreCase)))
                return [];

            content = [
                $"IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}' AND COLUMN_NAME = 'cmm')",
                $"BEGIN",
                $"	{newColumnScript}",
                $"END",
            ];

            return content;
        }

        private void GenerateFile(string directory, string file, List<string> content)
            => Utilities.GenerateFile(_destinyPath, directory, file, content);
    }
}
