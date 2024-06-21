using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator.BLL
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
            List<string> allNewLines;
            string line;
            string tableName;

            template = [.. File.ReadAllLines(fileModel.Path)];
            linesByTable = [];
            spTableRoot = [];
            spRoot = [];
            allNewLines = [];

            for (int i = 0; i < template.Count; i++)
            {
                line = template[i];

                if (line.StartsWith("print '") && line.EndsWith("'"))
                {
                    tableName = GetTableName(line);
                    spTableRoot = ExtractSPsByTable(tableName, linesByTable, ref allNewLines);

                    allNewLines.Add("------------------------------------------");
                    allNewLines.Add($"PRINT '{tableName}'");
                    allNewLines.Add("------------------------------------------");

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
            Utilities.GenerateFile(_destinyPath, "AllScripts", "01_All_scripts" + fileModel.Name + ".sql", allNewLines);
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

        private List<string> ExtractSPsByTable(string tableName, List<string> templateTable, ref List<string> allNewLines)
        {
            List<string> sp;
            List<string> spRoot;
            string line;
            string spName;
            string viewName;
            bool isView;
            bool isSelMSP;

            const string separator = "----------------------";
            const string ifExists = "IF  EXISTS (SELECT * FROM ";

            sp = [];
            spRoot = [];
            spName = "SPNoName";
            viewName = "VIEWNoName";
            isView = false;
            isSelMSP = false;

            for (int i = 0; i < templateTable.Count; i++)
            {
                line = templateTable[i];

                if (line.StartsWith(separator))
                {
                    if (isView)
                    {
                        int endViewIndex = sp.FindLastIndex(x => x.StartsWith("WHERE [") && x.EndsWith("].active=1"));

                        if (endViewIndex == -1)
                            endViewIndex = sp.FindLastIndex(x => x.Contains("INNER JOIN ["));

                        endViewIndex += 6;

                        List<string> viewContent = sp.GetRange(0, endViewIndex);

                        allNewLines.Add("------------------------------------------");
                        allNewLines.AddRange(viewContent);
                        Utilities.GenerateFile(_destinyPath, Path.Combine("Views", tableName), viewName, viewContent);
                        spRoot.Add(Path.Combine("Views", tableName, viewName).Replace(@"\", "/"));

                        GenerateBasicView(viewContent, tableName, ref spRoot, ref allNewLines);

                        sp = sp.GetRange(endViewIndex, sp.Count - endViewIndex);
                    }

                    allNewLines.Add("------------------------------------------");
                    allNewLines.AddRange(sp);
                    Utilities.GenerateFile(_destinyPath, Path.Combine("StoreProcedures", tableName), spName, sp);
                    spRoot.Add(Path.Combine("StoreProcedures", tableName, spName).Replace(@"\", "/"));

                    isView = false;
                    isSelMSP = false;
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
                        {
                            spName = line[start..end] + ".sql";
                            isSelMSP = spName.StartsWith($"sel_{tableName.Replace(".", "_")}") && spName.EndsWith($"_m.sql") && spName.Contains('X', StringComparison.CurrentCulture);
                        }

                        if (!isView)
                            isView = spName.StartsWith("view_");

                        if (isView && spName.StartsWith("view_"))
                        {
                            viewName = spName;
                            spName = string.Empty;
                        }
                    }

                    if (isSelMSP && line.Contains("@p_eid as varchar(50)"))
                    {
                        sp[^1] = line + ",";
                        sp.Add("	@p_cmm VARCHAR(300) = NULL,");
                        sp.Add("	@p_retorno INT = 1");
                    }

                    if (isSelMSP && line.Contains("BEGIN"))
                    {
                        i += 1;
                        sp.AddRange(GetSelSP(ref i, tableName, templateTable));
                        i -= 1;
                    }
                }
            }

            GenerateUpdateCmmSP(tableName, ref allNewLines, ref spRoot);

            return spRoot;
        }

        private List<string> GenerateUpdateCmmSP(string tableName, ref List<string> allNewLines, ref List<string> spRoot)
        {
            string spName;
            string spNameFile;
            List<string> sp = [];
            List<string> updateParent = [];
            string principalColumn;
            string parentTableName;
            string cmmValue;

            if (tableName.StartsWith('_'))
                return sp;

            spName = $"upd_{tableName.Replace('.', '_')}_cmm";
            spNameFile = $"{spName}.sql";
            principalColumn = tableName[4..];

            if (tableName == "ort_reporteTecnico_ot" && principalColumn == "reporteTecnico_ot" ||
                tableName == "seg_sesionHistorico" && principalColumn == "sesionHistorico")
                cmmValue = "''";
            else
                cmmValue = $"CASE WHEN [{principalColumn}] IN ('', NULL) THEN '' ELSE CONCAT('[', [{principalColumn}], ']') END";

            if (tableName.StartsWith("doc_documento.") || tableName.StartsWith("cat_catalogo."))
            {
                parentTableName = tableName.Split(".").First();

                updateParent.AddRange([
                    $"",
                    $"	UPDATE [{parentTableName}]",
                    $"	SET [{parentTableName}].cmm = tabla.cmm,",
                    $"		id_usuario_modifico = @p_id_usuario_modifico,",
                    $"		fechaModificacion = GETDATE()",
                    $"	FROM [{tableName}] tabla",
                    $"		INNER JOIN @p_ids ids",
                    $"	ON tabla.id = ids.Id",
                    $"	WHERE",
                    $"		tabla.eid = @p_eid",
                ]);
            }

            sp.AddRange([
                $"SET QUOTED_IDENTIFIER OFF",
                $"GO",
                $"SET ANSI_NULLS OFF",
                $"GO",
                $"",
                $"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{spName}]') AND type in (N'P', N'PC'))DROP PROCEDURE [dbo].[{spName}]",
                $"GO",
                $"CREATE PROCEDURE [dbo].[{spName}]",
                $"	@p_ids AS typ_ids READONLY,",
                $"	@p_id_usuario_modifico int,",
                $"	@p_eid varchar(50)",
                $"AS",
                $"BEGIN",
                $"",
                $"	SET NOCOUNT OFF;",
                $"	",
                $"	UPDATE [{tableName}]",
                $"	SET cmm = {cmmValue},",
                $"		id_usuario_modifico = @p_id_usuario_modifico,",
                $"		fechaModificacion = GETDATE()",
                $"	FROM [{tableName}] tabla",
                $"		INNER JOIN @p_ids ids",
                $"	ON tabla.id = ids.Id",
                $"	WHERE",
                $"		eid = @p_eid",
            ]);

            sp.AddRange(updateParent);

            sp.AddRange([
                $"END",
                $"GO",
                $"SET QUOTED_IDENTIFIER OFF ",
                $"GO",
                $"SET ANSI_NULLS ON",
                $"GO",
                $"",
            ]);


            allNewLines.Add("------------------------------------------");
            allNewLines.AddRange(sp);
            Utilities.GenerateFile(_destinyPath, Path.Combine("StoreProcedures", tableName), spNameFile, sp);
            spRoot.Add(Path.Combine("StoreProcedures", tableName, spNameFile).Replace(@"\", "/"));

            return sp;
        }

        private List<string> GetSelSP(ref int index, string tableName, List<string> template)
        {
            List<string> content = [];
            List<string> originalContent = [];
            List<string> returnType = ["TABLE", "VIEW", "VIEWBASE"];
            string line;
            string nameType;

            for (int i = index; i < template.Count; i++)
            {
                line = template[i];
                index = i;
                if (line.Contains("END"))
                    break;

                originalContent.Add("	" + line);
            }

            for (int t = 0; t < returnType.Count; t++)
            {
                nameType = returnType[t];

                content.AddRange([
                        $"	{(t != 0 ? "ELSE " : "")}IF @p_retorno = {t} -- {nameType}",
                        $"	BEGIN"
                    ]);

                for (int i = 0; i < originalContent.Count; i++)
                {
                    line = originalContent[i];

                    if (line.Contains($"FROM [view_{tableName}]"))
                    {
                        switch (t)
                        {
                            case 0:
                                line = line.Replace($"FROM [view_{tableName}]", $"FROM [{tableName}]");
                                break;
                            case 1:
                                line = line.Replace($"FROM [view_{tableName}]", $"FROM [view_{tableName.Replace(".", "_")}]");
                                break;
                            case 2:
                                line = line.Replace($"FROM [view_{tableName}]", $"FROM [view_{tableName.Replace(".", "_")}_base]");
                                break;
                            default:
                                break;
                        }
                    }

                    content.Add(line);

                }
                content.AddRange([
                       $"		AND (@p_cmm IS NULL OR [cmm] LIKE '%' + @p_cmm + '%')",
                       $"		AND ([active] = 1)",
                       $"	END",
                       ""
                   ]);
            }

            return content;
        }

        public string GenerateBasicViews()
        {
            List<string> spRoot = [];
            List<string> allViewsContent = [];
            List<string> allNewLines = [];
            List<FileModel> fileModels = Utilities.GetFilesModel([..
                Directory.GetFileSystemEntries(_rootPath).
                    Select(x =>
                        Path.Combine(x, $"view_{x.Split(@"\").Last()}.sql"))]);
            string tableName;

            foreach (FileModel fileModel in fileModels)
            {
                fileModel.Path = fileModel.Path.Replace($"{fileModel.Name}.sql", $"{fileModel.Name.Replace(".", "_")}.sql");
                if (!File.Exists(fileModel.Path)) continue;

                List<string> viewTemplate = [.. File.ReadAllLines(fileModel.Path)];
                tableName = fileModel.Name.Replace("view_", "");

                allViewsContent.AddRange(GenerateBasicView(viewTemplate, tableName, ref spRoot, ref allNewLines));
                allViewsContent.Add("------------------------------------------");
                allViewsContent.Add($"PRINT 'view_{tableName}_base'");
                allViewsContent.Add("------------------------------------------");

                Utilities.GenerateFile(_destinyPath, Path.Combine("Views", tableName), $"{fileModel.Name}.sql", viewTemplate);
            }

            Utilities.GenerateFile(_destinyPath, "Roots", "01_All_views" + ".txt", spRoot);
            Utilities.GenerateFile(_destinyPath, "AllBasicsViews", "Views" + ".sql", allViewsContent);

            return "Ok";
        }

        private List<string> GenerateBasicView(List<string> seedViewContent, string tableName, ref List<string> spRoot, ref List<string> allNewLines)
        {
            List<string> basicViewContent = [];
            string tableNameNotDot = tableName.Replace(".", "_");
            string basicViewName = $"view_{tableNameNotDot}_base";
            string viewName = $"view_{tableNameNotDot}";
            bool inAForeignTable = false;

            string tableNameFilter;

            for (int i = 0; i < seedViewContent.Count; i++)
            {
                string line = seedViewContent[i];
                if (line.Contains($"[{viewName}]"))
                    line = line.Replace($"[{viewName}]", $"[{basicViewName}]");

                if (line.Contains($"] AS [{tableNameNotDot}_id_"))
                    tableNameFilter = $"] AS [{tableNameNotDot}_id_";
                else
                    tableNameFilter = $"] AS [id_";

                if (!line.Contains("].[id_usuario_modifico] AS [id_usuario_modifico],", StringComparison.CurrentCultureIgnoreCase) &&
                    !line.Contains("].[id_usuario_creo] AS [id_usuario_creo],", StringComparison.CurrentCultureIgnoreCase) &&
                    line.Contains(tableNameFilter, StringComparison.CurrentCultureIgnoreCase))
                {
                    basicViewContent.Add(line);

                    i++;
                    line = seedViewContent[i];
                    basicViewContent.Add(line);

                    inAForeignTable = true;
                }
                else
                {
                    if (inAForeignTable &&
                        !line.TrimStart().StartsWith($"[{tableName}]") &&
                        !line.TrimStart().Equals("[empresaCodigo].[empresa] As [multiempresa]"))
                    {
                        if (
                            line.EndsWith("_codigo],") ||
                            line.EndsWith("_codigoInventario],") ||
                            line.EndsWith("_serial],") ||
                            line.EndsWith("_nit],") ||
                            line.EndsWith("_identificacion],") ||
                            line.EndsWith("_numero],") ||
                            line.EndsWith("prefijo],") ||
                            line.EndsWith("identificador],"))
                        {
                            basicViewContent.Add(line);
                        }

                        continue;
                    }

                    inAForeignTable = false;
                    basicViewContent.Add(line);
                }
            }

            allNewLines.Add("------------------------------------------");
            allNewLines.AddRange(basicViewContent);
            Utilities.GenerateFile(_destinyPath, Path.Combine("Views", tableName), $"{basicViewName}.sql", basicViewContent);
            spRoot.Add(Path.Combine("Views", tableName, $"{basicViewName}.sql").Replace(@"\", "/"));

            return basicViewContent;
        }
    }
}
