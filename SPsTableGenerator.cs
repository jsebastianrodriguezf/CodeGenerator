using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator
{
    public class SPsTableGenerator
    {
        private readonly string _rootPath;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;
        private readonly string _destinyPath;

        public SPsTableGenerator(
            string rootPath,
            string destityPath)
        {
            _rootPath = rootPath;
            _destinyPath = destityPath;
            _files = [.. Directory.GetFiles(_rootPath)];
            _filesModel = Utilities.GetFilesModel(_files);
            Utilities.RegenerateDirectory(_destinyPath);
        }

        public string GenerateSPs()
        {
            foreach (FileModel fileModel in _filesModel)
            {
                GenerateSPs(fileModel);
            }

            return "Ok";
        }

        public void GenerateSPs(FileModel fileModel)
        {
            List<string> template;
            List<string> linesByTable;
            List<string> spRoot;
            List<string> spTableRoot;
            string line;
            string tableName;

            template = [.. File.ReadAllLines(fileModel.Path)];
            linesByTable = [];
            spTableRoot = [];
            spRoot = [];

            for (int i = 0; i < template.Count; i++)
            {
                line = template[i];

                if (line.StartsWith("print '") && line.EndsWith("'"))
                {
                    tableName = GetTableName(line);
                    spTableRoot = ExtractSPsByTable(tableName, linesByTable);

                    spRoot.AddRange(spTableRoot);

                    Utilities.GenerateFile(_destinyPath, "Roots", tableName + ".txt", spTableRoot);

                    i += 1;
                    linesByTable = []; 
                }
                else
                {
                    linesByTable.Add(line);
                }
            }

            Utilities.GenerateFile(_destinyPath, "Roots", "01_All_" + fileModel.Name + ".txt", spRoot);
        }

        private string GetTableName(string line)
        {
            string tableName = "NoName";
            int start = line.IndexOf("'", 0) + 1;
            int end = line.IndexOf("'", start);
            if (start < end)
                tableName = line[start..end];

            return tableName;
        }

        private List<string> ExtractSPsByTable(string tableName, List<string> templateTable)
        {
            List<string> sp;
            List<string> spRoot;
            string line;
            string spName;
            string viewName;
            bool isView;

            const string separator = "----------------------";
            const string ifExists = "IF  EXISTS (SELECT * FROM ";

            sp = [];
            spRoot = [];
            spName = "SPNoName";
            viewName = "VIEWNoName";
            isView = false;

            for (int i = 0; i < templateTable.Count; i++)
            {
                line = templateTable[i];

                if (line.StartsWith(separator))
                {
                    if (isView)
                    {
                        int endViewIndex = sp.FindLastIndex(x => x.StartsWith("WHERE [") && x.EndsWith("].active=1")) + 6;
                        Utilities.GenerateFile(_destinyPath, Path.Combine("Views", tableName), viewName, sp.GetRange(0, endViewIndex));
                        spRoot.Add(Path.Combine("Views", tableName, viewName).Replace(@"\", "/"));

                        sp = sp.GetRange(endViewIndex, sp.Count - endViewIndex);
                    }

                    Utilities.GenerateFile(_destinyPath, Path.Combine("StoreProcedures", tableName), spName, sp);
                    spRoot.Add(Path.Combine("StoreProcedures", tableName, spName).Replace(@"\", "/"));

                    isView = false;
                    sp = [];
                    spName = "NoName";
                }
                else
                {
                    sp.Add(line);

                    if (line.StartsWith(ifExists) && line.EndsWith("]"))
                    {
                        int start = line.LastIndexOf("[dbo].[") + 7;
                        int end = line.LastIndexOf("]");
                        if (start < end)
                            spName = line[start..end] + ".sql";

                        if (!isView)
                            isView = spName.StartsWith("view_");

                        if (isView && spName.StartsWith("view_"))
                        {
                            viewName = spName;
                            spName = string.Empty;
                        }
                    }
                }
            }

            return spRoot;
        }
    }
}
