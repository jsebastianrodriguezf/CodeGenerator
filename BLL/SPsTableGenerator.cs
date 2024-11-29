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
        private readonly string _customSPsPath;
        private readonly List<string> _customSPsFiles;
        private readonly List<FileModel> _customSPsFilesModel;
        private readonly string _customFunctionsPath;
        private readonly List<string> _customFunctionsFiles;
        private readonly List<FileModel> _customFunctionsFilesModel;

        public SPsTableGenerator(
            string rootPath,
            string destityPath,
            string customSPsPath,
            string customFunctionsPath)
        {
            _rootPath = rootPath;
            _destinyPath = destityPath;
            _customSPsPath = customSPsPath;
            _customFunctionsPath = customFunctionsPath;
            _files = [.. Directory.GetFiles(_rootPath)];
            _filesModel = Utilities.GetFilesModel(_files);

            _customSPsFiles = [.. Directory.GetFiles(_customSPsPath)];
            _customSPsFilesModel = Utilities.GetFilesModel(_customSPsFiles);

            _customFunctionsFiles = [.. Directory.GetFiles(_customFunctionsPath)];
            _customFunctionsFilesModel = Utilities.GetFilesModel(_customFunctionsFiles);

            Utilities.RegenerateDirectory(_destinyPath);
        }

        public string GenerateSPs()
        {
            foreach (FileModel fileModel in _filesModel.Where(x => x.Extension == "sql"))
            {
                GenerateSPs(fileModel);
            }

            return "Ok";
        }

        public void GenerateSPs(FileModel fileModel)
        {
            (List<string> drop, List<string> create) customSP;
            (List<string> drop, List<string> create) customFunction;
            List<string> template;
            List<string> linesByTable;
            List<string> spRoot;
            List<string> spTableRoot;
            List<string> allNewLines;
            List<string> finalScripts;
            List<string> allTypes;
            List<string> allDropTypeSP;
            string line;
            string tableName;
            string principalColumn;
            bool hasCmm;
            bool hasPrincipalColumn;

            const string cmm = "[cmm] AS [cmm]";

            template = [.. File.ReadAllLines(fileModel.Path)];
            linesByTable = [];
            spTableRoot = [];
            spRoot = [];
            allNewLines = [];
            finalScripts = [];
            allTypes = [];
            allDropTypeSP = [];
            hasCmm = false;

            List<string> atributoWhiteList = ["equ_equipoAtributo", "doc_documentoAtributo", "cat_atributo_opcionAtributo", "cat_usoSeccionAtributo", "cat_pruebaCheckList_atributo", "cat_atributo", "equ_opcionAtributo"];

            for (int i = 0; i < template.Count; i++)
            {
                line = template[i];

                if (line.StartsWith("print '") && line.EndsWith("'"))
                {
                    tableName = GetTableName(line);
                    if (tableName.EndsWith("atributo", StringComparison.CurrentCultureIgnoreCase) && !atributoWhiteList.Contains(tableName))
                    {
                        i += 1;
                        linesByTable = [];
                        hasCmm = false;
                        continue;
                    }
                    principalColumn = tableName.Remove(0, 4);

                    hasPrincipalColumn = linesByTable.Any(x => x.Contains($"[{principalColumn}] AS [{principalColumn}]"));

                    spTableRoot = ExtractSPsByTable(tableName, linesByTable, hasCmm, hasPrincipalColumn, ref allNewLines, ref allTypes);

                    allNewLines.Add("------------------------------------------");
                    allNewLines.Add($"PRINT '{tableName}'");
                    allNewLines.Add("------------------------------------------");

                    allTypes.Add("------------------------------------------");
                    allTypes.Add($"PRINT 'typ_{tableName}'");
                    allTypes.Add("------------------------------------------");

                    spRoot.AddRange(spTableRoot);
                    allDropTypeSP.AddRange(DropTypeSp(tableName));
                    Utilities.GenerateFile(_destinyPath, "Roots", tableName + ".txt", spTableRoot);

                    i += 1;
                    linesByTable = [];
                    hasCmm = false;
                }
                else
                {
                    linesByTable.Add(line);

                    if (!hasCmm && (line.EndsWith(cmm) || line.EndsWith(cmm + ",")))
                    {
                        hasCmm = true;
                    }
                }
            }

            customSP = GetCustomSPS();
            customFunction = GetCustomFunctions();

            finalScripts.AddRange(customSP.drop);
            finalScripts.AddRange(customFunction.drop);
            finalScripts.AddRange(allDropTypeSP);
            finalScripts.AddRange(allTypes);
            finalScripts.AddRange(allNewLines);
            finalScripts.AddRange(customSP.create);

            Utilities.GenerateFile(_destinyPath, "Roots", "01_All_" + fileModel.Name + ".txt", spRoot);
            Utilities.GenerateFile(_destinyPath, "AllScripts", "01_All_scripts_" + fileModel.Name + ".sql", finalScripts);
        }

        private (List<string> drop, List<string> create) GetCustomSPS()
        {
            List<string> content = [];
            (List<string> drop, List<string> create) response;
            response.drop = [];
            response.create = [];

            foreach (FileModel file in _customSPsFilesModel)
            {
                response.create.Add("GO");
                response.create.AddRange(File.ReadAllLines(file.Path));
                response.create.AddRange([
                    "GO",
                    "------------------------------------------",
                    $"PRINT 'custom_sp_{file.Name}'",
                    "------------------------------------------"
                ]);
                response.drop.AddRange([
                    $"IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{file.Name}]') AND type in (N'P', N'PC'))DROP PROCEDURE [dbo].[{file.Name}]",
                    $"GO",
                    "------------------------------------------",
                    $"PRINT 'custom_drop_{file.Name}'",
                    "------------------------------------------"
                ]);
            }

            return response;
        }

        private (List<string> drop, List<string> create) GetCustomFunctions()
        {
            List<string> content = [];
            (List<string> drop, List<string> create) response;
            response.drop = [];
            response.create = [];

            foreach (FileModel file in _customFunctionsFilesModel)
            {
                response.create.Add("GO");
                response.create.AddRange(File.ReadAllLines(file.Path));
                response.create.AddRange([
                    "GO",
                    "------------------------------------------",
                    $"PRINT 'custom_function_{file.Name}'",
                    "------------------------------------------"
                ]);
                response.drop.AddRange([
                    $"IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{file.Name}]') AND type in (N'FN', N'IF', N'TF'))DROP FUNCTION [dbo].[{file.Name}]",
                    $"GO",
                    "------------------------------------------",
                    $"PRINT 'custom_drop_{file.Name}'",
                    "------------------------------------------"
                ]);
            }

            return response;
        }

        private List<string> DropTypeSp(string tableName)
        {
            string tableNameSimple = tableName.Replace('.', '_');
            return [
                $"IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ins_{tableNameSimple}_bulk]') AND type in (N'P', N'PC'))DROP PROCEDURE [dbo].[ins_{tableNameSimple}_bulk]",
                $"GO",
                $"IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[upd_{tableNameSimple}_bulk]') AND type in (N'P', N'PC'))DROP PROCEDURE [dbo].[upd_{tableNameSimple}_bulk]",
                $"GO",
                "------------------------------------------",
                $"PRINT 'sp_{tableName}'",
                "------------------------------------------"
            ];
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

        private List<string> ExtractSPsByTable(string tableName, List<string> templateTable, bool hasCmm, bool hasPrincipalColumn, ref List<string> allNewLines, ref List<string> allTypes)
        {
            List<string> sp;
            List<string> spRoot;
            string line;
            string spName;
            string viewName;
            string insertName;
            string idParamSelMSP;
            bool isView;
            bool isInsert;
            bool isActive;
            bool isUpdate;
            bool isSelMSP;
            bool isSelAllSP;

            const string separator = "----------------------";
            const string ifExists = "IF  EXISTS (SELECT * FROM ";

            bool hasParentTable = HasParentTable(tableName);

            sp = [];
            spRoot = [];
            spName = "SPNoName";
            viewName = "VIEWNoName";
            insertName = "INSERTNoName";
            idParamSelMSP = "";
            isView = false;
            isInsert = false;
            isActive = false;
            isUpdate = false;
            isSelMSP = false;
            isSelAllSP = false;

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

                        if (hasParentTable)
                            GenerateParentFullView(viewContent, tableName, ref spRoot, ref allNewLines);

                        GenerateBasicView(viewContent, tableName, ref spRoot, ref allNewLines);

                        //a store procedure that is a side of main view
                        sp = sp.GetRange(endViewIndex, sp.Count - endViewIndex);
                    }

                    if (isInsert)
                    {
                        sp = CleanInsertSP(sp, tableName, hasCmm);
                        GenerateType(sp, tableName, ref spRoot, ref allTypes);

                        allNewLines.Add("------------------------------------------");
                        allNewLines.AddRange(sp);
                        Utilities.GenerateFile(_destinyPath, Path.Combine("StoreProcedures", tableName), spName, sp);
                        spRoot.Add(Path.Combine("StoreProcedures", tableName, spName).Replace(@"\", "/"));

                        List<string> updateContent = GenerateBulkUpdate(sp, tableName, ref spRoot, ref allNewLines, hasCmm);
                        allNewLines.Add("------------------------------------------");
                        allNewLines.AddRange(updateContent);
                        Utilities.GenerateFile(_destinyPath, Path.Combine("StoreProcedures", tableName), $"upd_{tableName.Replace('.', '_')}_bulk.sql", updateContent);
                        spRoot.Add(Path.Combine("StoreProcedures", tableName, $"upd_{tableName.Replace('.', '_')}_bulk.sql").Replace(@"\", "/"));

                        sp = GenerateBulkInsert(sp, tableName, ref spRoot, ref allNewLines, hasCmm);
                        spName = spName.Replace(".sql", "_bulk.sql");
                    }

                    if (isActive)
                        sp = UpdateActiveSP(sp, tableName);

                    if (isUpdate)
                        sp = CleanUpdateSP(sp, tableName, hasCmm);

                    allNewLines.Add("------------------------------------------");
                    allNewLines.AddRange(sp);
                    Utilities.GenerateFile(_destinyPath, Path.Combine("StoreProcedures", tableName), spName, sp);
                    spRoot.Add(Path.Combine("StoreProcedures", tableName, spName).Replace(@"\", "/"));

                    isView = false;
                    isInsert = false;
                    isUpdate = false;
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
                        int end = line.LastIndexOf(']');
                        if (start < end)
                        {
                            spName = line[start..end] + ".sql";
                            isSelMSP = spName.StartsWith($"sel_{tableName.Replace(".", "_")}") && spName.EndsWith($"_m.sql") && spName.Contains('X', StringComparison.CurrentCulture);
                            isSelAllSP = spName.StartsWith($"sel_{tableName.Replace(".", "_")}") && spName.EndsWith($"_m.sql") && !spName.Contains('X', StringComparison.CurrentCulture);
                        }

                        if (!isView)
                            isView = spName.StartsWith("view_");

                        if (isView && spName.StartsWith("view_"))
                        {
                            viewName = spName;
                            spName = string.Empty;
                        }

                        if (!isInsert)
                            isInsert = spName.StartsWith($"ins_{tableName.Replace('.', '_')}");

                        if (isInsert && spName.StartsWith($"ins_{tableName.Replace('.', '_')}"))
                        {
                            insertName = spName;
                            //spName = string.Empty;
                        }

                        if (!isActive)
                            isActive = spName.StartsWith($"act_{tableName.Replace('.', '_')}");

                        if (!isUpdate)
                            isUpdate = spName.StartsWith($"upd_{tableName.Replace('.', '_')}");
                    }

                    if (isSelMSP && line.Contains("@p_eid as varchar(50)"))
                    {
                        idParamSelMSP = sp[^2].Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).First().TrimStart();
                        sp[^2] = "	@p_id INT, -- " + idParamSelMSP.Replace("@p_", string.Empty);
                        sp[^1] = line + ",";
                        sp.Add("	@p_cmm VARCHAR(300) = NULL,");
                        sp.Add("	@p_retorno INT = 1");
                    }

                    if (isSelMSP && line.Contains("BEGIN"))
                    {
                        i += 1;
                        sp.AddRange(GetSelSP(ref i, tableName, templateTable, hasCmm, idParamSelMSP, hasParentTable));
                        i -= 1;
                    }

                    if (isSelAllSP && line.Contains("@p_eid as varchar (50)='',"))
                    {
                        sp.Add("	@p_cmm VARCHAR(300) = NULL,");
                        sp.Add("	@p_retorno INT = 1");
                        sp.Add("AS");

                        i += 3;
                    }

                    if (isSelAllSP && line.Contains("BEGIN"))
                    {
                        i += 1;
                        sp.AddRange(GetAllSP(ref i, tableName, templateTable, hasCmm, hasPrincipalColumn, hasParentTable));
                        i += 2;
                    }
                }
            }

            if (hasCmm)
                GenerateUpdateCmmSP(tableName, ref allNewLines, ref spRoot);

            return spRoot;
        }

        private bool HasParentTable(string tableName)
        {
            return (tableName.StartsWith("doc_documento.") || tableName.StartsWith("cat_catalogo.")) && tableName.Split('.').Length == 2 && !tableName.Split('.')[1].Contains('_');
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
                $"SET QUOTED_IDENTIFIER ON",
                $"GO",
                $"SET ANSI_NULLS ON",
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
                $"SET ANSI_NULLS OFF",
                $"GO",
                $"",
            ]);


            allNewLines.Add("------------------------------------------");
            allNewLines.AddRange(sp);
            Utilities.GenerateFile(_destinyPath, Path.Combine("StoreProcedures", tableName), spNameFile, sp);
            spRoot.Add(Path.Combine("StoreProcedures", tableName, spNameFile).Replace(@"\", "/"));

            return sp;
        }

        private List<string> GetSelSP(ref int index, string tableName, List<string> template, bool hasCmm, string idParamSelMSP, bool hasParentTable)
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
                                line = line.Replace($"FROM [view_{tableName}]", $"FROM [{(hasParentTable ? $"view_{tableName.Replace(".", "_")}_full" : tableName)}]");
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

                    line = line.Replace(idParamSelMSP, "@p_id");
                    content.Add(line);

                }
                content.AddRange([
                       $"		AND (@p_cmm IS NULL{(hasCmm ? " OR [cmm] LIKE '%' + @p_cmm + '%'" : "")})",
                       $"		AND ([active] = 1)",
                       $"	END",
                       ""
                   ]);
            }

            return content;
        }

        private List<string> GetAllSP(ref int index, string tableName, List<string> template, bool hasCmm, bool hasPrincipalColumn, bool hasParentTable)
        {
            List<string> content;
            List<string> cmmCondition;
            string principalColumn;
            string tableWithoutDot;

            content = [];
            principalColumn = tableName.Remove(0, 4);
            tableWithoutDot = tableName.Replace(".", "_");

            cmmCondition = [
                $"			(eid LIKE @p_eid+'%') AND",
                $"			(",
                $"				@p_cmm IS NULL OR",
                $"				(",
            ];

            if (hasPrincipalColumn)
                cmmCondition.AddRange([
                    $"					([cmm] IS NULL AND [{principalColumn}] LIKE '%' + @p_cmm + '%') OR ",
                    $"					([cmm] IS NOT NULL AND [cmm] LIKE '%' + @p_cmm + '%')",
                ]);
            else
                cmmCondition.AddRange([
                   $"					[cmm] IS NOT NULL AND [cmm] LIKE '%' + @p_cmm + '%'",
                ]);

            cmmCondition.AddRange([
                $"				)",
                $"			)",
            ]);

            content.AddRange([
                $"	IF @p_retorno = 0 -- TABLE",
                $"	BEGIN",
                $"		SELECT *",
                $"		FROM [{(hasParentTable ? $"view_{tableWithoutDot}_full" : tableName)}]",
                $"		WHERE",
                $"			([active] = 1) AND",
            ]);

            if (hasCmm)
                content.AddRange(cmmCondition);
            else
                content.Add($"			(eid LIKE @p_eid+'%')");

            content.AddRange([
                $"	END",
                $"",
                $"	ELSE IF @p_retorno = 1 -- VIEW",
                $"	BEGIN",
                $"		SELECT *",
                $"		FROM [view_{tableWithoutDot}]",
                $"		WHERE",
                $"			([active] = 1) AND",
            ]);

            if (hasCmm)
                content.AddRange(cmmCondition);
            else
                content.Add($"			(eid LIKE @p_eid+'%')");

            content.AddRange([
                $"	END",
                $"",
                $"	ELSE IF @p_retorno = 2 -- VIEWBASE",
                $"	BEGIN",
                $"		SELECT *",
                $"		FROM [view_{tableWithoutDot}_base]",
                $"		WHERE",
                $"			([active] = 1) AND",
            ]);

            if (hasCmm)
                content.AddRange(cmmCondition);
            else
                content.Add($"			(eid LIKE @p_eid+'%')");

            content.AddRange([
                $"	END",
            ]);

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

        private List<string> GenerateParentFullView(List<string> seedViewContent, string tableName, ref List<string> spRoot, ref List<string> allNewLines)
        {
            List<string> basicViewContent = [];
            string tableNameNotDot = tableName.Replace(".", "_");
            string basicViewName = $"view_{tableNameNotDot}_full";
            string viewName = $"view_{tableNameNotDot}";

            int indexSELECT = seedViewContent.FindIndex(x => x.StartsWith($"SELECT 	[{tableName}]", StringComparison.CurrentCultureIgnoreCase));
            int indexFROM = seedViewContent.FindIndex(x => x.StartsWith($"FROM [{tableName}]", StringComparison.CurrentCultureIgnoreCase));
            int indexWHERE = seedViewContent.FindIndex(x => x.Contains($"WHERE [{tableName}].active=1", StringComparison.CurrentCultureIgnoreCase));

            for (int i = 0; i < seedViewContent.Count; i++)
            {
                string line = seedViewContent[i];
                if (line.Contains($"[{viewName}]"))
                    line = line.Replace($"[{viewName}]", $"[{basicViewName}]");

                if ((i > indexSELECT && i < indexFROM && !(line.TrimStart().StartsWith($"[{tableName}]") || line.TrimStart().StartsWith($"[{tableNameNotDot}]"))) ||
                    (i > indexFROM && i < indexWHERE && !line.Contains($"ON [{tableName}].id = [{tableNameNotDot}].id")) ||
                    i == indexWHERE)
                    continue;

                if (i > indexSELECT && i < indexFROM && line.TrimStart().StartsWith($"[{tableNameNotDot}]"))
                {
                    line = line.Replace($"{tableNameNotDot}_", "");
                    if (line.Contains($"[{tableNameNotDot}].[cmm] AS [cmm]"))
                        continue;
                }

                if (i == indexFROM)
                    basicViewContent[^1] = basicViewContent[^1].Replace(",", string.Empty);

                basicViewContent.Add(line);
            }

            allNewLines.Add("------------------------------------------");
            allNewLines.AddRange(basicViewContent);
            Utilities.GenerateFile(_destinyPath, Path.Combine("Views", tableName), $"{basicViewName}.sql", basicViewContent);
            spRoot.Add(Path.Combine("Views", tableName, $"{basicViewName}.sql").Replace(@"\", "/"));

            return basicViewContent;
        }

        private List<string> GenerateType(List<string> seedContent, string tableName, ref List<string> spRoot, ref List<string> allTypes)
        {
            List<string> content = [];
            int indexFirstColumn;
            int indexLastColumn;
            string line;
            string column;
            string tableNameSimple = tableName.Replace('.', '_');

            const string prefix = "@p_";

            indexFirstColumn = seedContent.FindIndex(x => x.Contains($"@p_id_usuario_creo int", StringComparison.CurrentCultureIgnoreCase)) + 1;
            indexLastColumn = seedContent.FindIndex(x => x.TrimStart().StartsWith($"AS", StringComparison.CurrentCultureIgnoreCase)) - 1;

            content.AddRange([
                $"SET QUOTED_IDENTIFIER OFF",
                $"GO",
                $"SET ANSI_NULLS OFF",
                $"GO",
                $"",
                $"IF EXISTS (SELECT 1 FROM sys.types WHERE name = 'typ_{tableNameSimple}' AND is_table_type = 1)DROP TYPE [dbo].[typ_{tableNameSimple}]",
                $"GO",
                $"CREATE TYPE [typ_{tableNameSimple}] AS TABLE",
                $"(",
                $"	id int,",
                $"	uid varchar(500),",
                $"	eid varchar(50),",
                $"	usuario_modifico int,",
                $"	usuario_creo int,",
                $"	fechaModificacion smalldatetime,",
                $"	fechaCreacion smalldatetime,",
                $"	active bit,",
            ]);

            for (int i = indexFirstColumn; i <= indexLastColumn; i++)
            {
                line = seedContent[i];
                column = line.TrimStart().Replace(prefix, string.Empty);

                if (tableName == "doc_documento" && column.TrimStart().StartsWith("cmm"))
                    content.Add($"	identificador varchar(25),");

                content.Add($"	{column}");
            }

            if (HasParentTable(tableName) && tableName.StartsWith("doc_documento."))
            {
                content[^1] = content[^1] + ",";
                content.Add($"	identificador varchar(25)");
            }

            content.AddRange([
                $");",
                $"GO",
                $"SET QUOTED_IDENTIFIER OFF ",
                $"GO",
                $"SET ANSI_NULLS ON",
                $"GO",
            ]);

            Utilities.GenerateFile(_destinyPath, Path.Combine("Types", tableName), $"typ_{tableNameSimple}.sql", content);
            spRoot.Add(Path.Combine("Types", tableName, $"typ_{tableNameSimple}.sql").Replace(@"\", "/"));

            allTypes.AddRange(content);

            return content;
        }

        private List<string> GenerateBulkInsert(List<string> seedContent, string tableName, ref List<string> spRoot, ref List<string> allNewLines, bool hasCmm)
        {
            List<string> content = [];
            List<string> columns = [];
            (string? tableName, List<string> content) parentInsert;
            bool hasParentTable;
            bool isParentTable;
            int indexFirstColumn;
            int indexLastColumn;
            string line;
            string column;

            string tableNameSimple = tableName.Replace('.', '_');

            isParentTable = tableName == "doc_documento" || tableName == "cat_catalogo";
            parentInsert = GetParentInsert(tableName, hasCmm);
            hasParentTable = !string.IsNullOrEmpty(parentInsert.tableName);

            indexFirstColumn = seedContent.FindIndex(x => x.Contains($"[fechaCreacion]", StringComparison.CurrentCultureIgnoreCase)) + 1;
            indexLastColumn = seedContent.FindIndex(x => x.Contains($"VALUES", StringComparison.CurrentCultureIgnoreCase)) - 1;

            for (int i = indexFirstColumn; i <= indexLastColumn; i++)
            {
                line = seedContent[i];
                column = line.TrimStart();
                columns.Add($"			{column}");
            }

            content.AddRange([
                $"SET QUOTED_IDENTIFIER ON",
                $"GO",
                $"SET ANSI_NULLS ON",
                $"GO",
                $"",
                $"IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ins_{tableNameSimple}_bulk]') AND type in (N'P', N'PC'))DROP PROCEDURE [dbo].[ins_{tableNameSimple}_bulk]",
                $"GO",
                $"CREATE PROCEDURE [ins_{tableNameSimple}_bulk]",
                $"	@p_{tableNameSimple} AS typ_{tableNameSimple} READONLY,",
                $"	@p_uid varchar(500),",
                $"	@p_eid varchar(50),",
                $"	@p_id_usuario int",
                $"AS",
                $"BEGIN",
                $"	DECLARE @v_ids AS typ_ids"
            ]);

            content.AddRange(parentInsert.content);

            if ( parentInsert.tableName is null)
            {
                if (!isParentTable)
                    content.AddRange([
                        $"",
                        $"	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;",
                        $"",
                        $"	BEGIN TRANSACTION;",
                    ]);

                content.AddRange([
                    $"",
                    $"	BEGIN TRY",
                ]);
            }

            content.AddRange([
                $"",
                $"		INSERT INTO [{tableName}]",
            ]);

            if (hasParentTable)
                content.Add("			([id],");

            content.AddRange([
                $"			{(hasParentTable ? "" : "(")}[uid],",
                $"			[eid],",
                $"			[id_usuario_creo],",
                $"			[id_usuario_modifico],",
                $"			[fechaCreacion],",
                $"			[fechaModificacion],",
            ]);

            content.AddRange(columns);

            content.AddRange([
                $"		OUTPUT inserted.id INTO @v_ids",
                $"		SELECT",
            ]);

            if (hasParentTable)
                content.AddRange([$"			{parentInsert.tableName}.id,"]);

            content.AddRange([
                $"			@p_uid,",
                $"			@p_eid,",
                $"			@p_id_usuario,",
                $"			@p_id_usuario,",
                $"			GETDATE(),",
                $"			GETDATE(),",
            ]);

            content.AddRange(columns.Select(x => x.Replace('.', '_')).Select(x =>
            {
                if (isParentTable && tableName == "doc_documento")
                {
                    x = x switch
                    {
                        "			[documento_numero]," => $"			doc_subtipoDocumento.consecutivo + ROW_NUMBER() OVER (PARTITION BY doc_subtipoDocumento.id ORDER BY doc_subtipoDocumento.id),",
                        "			[prefijo]," => $"			doc_subtipoDocumento.[prefijo],",
                        _ => x,
                    };
                }

                if (hasParentTable && x.Contains("[cmm]"))
                {
                    x = $"			''" + (x.Contains(',') ? "," : "");
                }

                if (isParentTable && tableName == "doc_documento" && x.Contains("[cmm]"))
                {
                    x = x.Replace("[cmm]", $"{tableNameSimple}.[cmm]");
                }


                return x;
            }));
            content[^1] = content[^1].Replace(")", "");

            if (isParentTable && tableName == "doc_documento")
            {
                content.AddRange([
                    $"		FROM @p_{tableNameSimple} {tableNameSimple}",
                    $"			INNER JOIN doc_subtipoDocumento",
                    $"		ON {tableNameSimple}.id_subtipoDocumento = doc_subtipoDocumento.id",
                    $"		WHERE",
                    $"			doc_subtipoDocumento.eid = @p_eid AND",
                    $"			doc_subtipoDocumento.active = 1",
                    $"",
                ]);
            }
            else if (!hasParentTable)
            {
                content.AddRange([
                    $"		FROM @p_{tableNameSimple}",
                    $"",
                ]);
            }
            else
            {
                content.AddRange([
                    $"		FROM @v_{tableNameSimple} {tableNameSimple}",
                    $"		    INNER JOIN @v_{parentInsert.tableName} {parentInsert.tableName}",
                    $"		ON {tableNameSimple}.cmm = {parentInsert.tableName}.cmm",
                    $"",
                ]);
            }

            if (!isParentTable)
                content.AddRange([
                    $"		COMMIT TRANSACTION;",
                    $"",
                    $"	END TRY",
                    $"	BEGIN CATCH",
                    $"		ROLLBACK TRANSACTION;",
                    $"		THROW;",
                    $"	END CATCH;",
                    $"",
                ]); 
            else
                content.AddRange([
                    $"	END TRY",
                    $"	BEGIN CATCH",
                    $"		THROW;",
                    $"	END CATCH;",
                    $"",
                ]);

            if (hasCmm && !isParentTable)
                content.AddRange([
                    $"	BEGIN TRY",
                    $"		EXEC upd_{tableNameSimple}_cmm @v_ids, @p_id_usuario, @p_eid",
                    $"	END TRY",
                    $"	BEGIN CATCH",
                    $"		PRINT 'ERROR [{tableName}]: ' + ERROR_MESSAGE();",
                    $"	END CATCH;",
                    $"",
                ]);

            if (isParentTable && tableName == "doc_documento")
            {
                content.AddRange([
                    $"	UPDATE doc_subtipoDocumento",
                    $"	SET ",
                    $"		consecutivo = temp.numero,",
                    $"		fechaModificacion = GETDATE(),",
                    $"		id_usuario_modifico = @p_id_usuario",
                    $"	FROM doc_subtipoDocumento",
                    $"		JOIN (",
                    $"			SELECT MAX(doc_documento.documento_numero) numero, doc_documento.id_subtipoDocumento",
                    $"			FROM @v_ids ids",
                    $"				INNER JOIN doc_documento",
                    $"			ON ids.Id = doc_documento.id",
                    $"			GROUP BY doc_documento.id_subtipoDocumento",
                    $"		) AS temp ",
                    $"	ON doc_subtipoDocumento.id = temp.id_subtipoDocumento",
                    $"",
                ]);
            }

            if (hasParentTable)
            {
                content.AddRange([
                    $"	SELECT [view_{tableName.Replace('.', '_')}_full].*",
                    $"	FROM [view_{tableName.Replace('.', '_')}_full]",
                    $"		INNER JOIN @v_ids ids",
                    $"	ON [view_{tableName.Replace('.', '_')}_full].id = ids.id",
                ]);
            }
            else
            {
                content.AddRange([
                    $"	SELECT [{tableName}].*",
                    $"	FROM [{tableName}]",
                    $"		INNER JOIN @v_ids ids",
                    $"	ON [{tableName}].id = ids.id",
                ]);
            }

            content.AddRange([
                $"END",
                $"GO",
                $"SET QUOTED_IDENTIFIER OFF",
                $"GO",
                $"SET ANSI_NULLS OFF",
                $"GO",
            ]);

            //allNewLines.AddRange(content);
            return content;
        }

        private (string? parentTable, List<string> parentInsert) GetParentInsert(string tableName, bool hasCmm)
        {
            (string? parentTable, List<string> parentInsert) response;
            List<string> content = [];
            string column;
            int indexFirstColumn;
            int indexLastColumn;
            string tableNameSimple = tableName.Replace('.', '_');

            if ((tableName.StartsWith("doc_documento.") || tableName.StartsWith("cat_catalogo.")) && tableNameSimple.Split('_').Length == 3)
            {
                response.parentTable = tableName.Split('.').First();
                List<string> parentTypeColumns = [];
                List<string> mainTypeColumns = [];

                List<string> template = [.. File.ReadAllLines(Path.Combine(_destinyPath, "Types", response.parentTable, $"typ_{response.parentTable}.sql"))];
                List<string> templateMain = [.. File.ReadAllLines(Path.Combine(_destinyPath, "Types", tableName, $"typ_{tableNameSimple}.sql"))];
                List<string> parentColumns;
                List<string> allMainColumns;
                int indexCmm;

                indexFirstColumn = template.FindIndex(x => x.Contains($"	active bit,", StringComparison.CurrentCultureIgnoreCase)) + 1;
                indexLastColumn = template.FindIndex(x => x.Contains($");", StringComparison.CurrentCultureIgnoreCase)) - 1;

                parentColumns = template.GetRange(indexFirstColumn, indexLastColumn - indexFirstColumn + 1);

                indexCmm = parentColumns.FindIndex(x => x.Contains("cmm ", StringComparison.CurrentCultureIgnoreCase));
                if (indexCmm > -1)
                    parentColumns.RemoveAt(indexCmm);

                if (parentColumns.Count > 0 && !parentColumns[^1].TrimEnd().EndsWith(','))
                    parentColumns[^1] = parentColumns[^1] + ",";

                for (int i = 0; i < parentColumns.Count; i++)
                {
                    column = parentColumns[i].TrimStart().Split(' ').First() + (i < parentColumns.Count - 1 ? "," : "");

                    if (column.TrimStart().StartsWith("identificador") && tableName.StartsWith("doc_documento."))
                        continue;
                    parentTypeColumns.Add($"		{column}");
                }

                if (hasCmm)
                {
                    if (tableName.StartsWith("cat_catalogo."))
                        parentTypeColumns[^1] = parentTypeColumns[^1] + ",";
                    parentTypeColumns.Add($"		cmm");
                }


                indexFirstColumn = templateMain.FindIndex(x => x.Contains($"CREATE TYPE ", StringComparison.CurrentCultureIgnoreCase)) + 2;
                indexLastColumn = templateMain.FindIndex(x => x.Contains($");", StringComparison.CurrentCultureIgnoreCase)) - 1;
                allMainColumns = templateMain.GetRange(indexFirstColumn, indexLastColumn - indexFirstColumn + 1);

                for (int i = 0; i < allMainColumns.Count; i++)
                {
                    column = allMainColumns[i].TrimStart().Split(' ').First() + (i < allMainColumns.Count - 1 ? "," : "");
                    mainTypeColumns.Add($"		{column}");
                }

                content.AddRange([
                     $"	DECLARE @v_{tableNameSimple} AS typ_{tableNameSimple}",
                     $"	DECLARE @v_{response.parentTable} AS typ_{response.parentTable}",
                     $"",
                     $"	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;",
                     $"",
                     $"	INSERT INTO @v_{tableNameSimple} (",
                ]);

                content.AddRange(mainTypeColumns);

                content.AddRange([
                    "	)",
                    $"	SELECT"
                ]);

                content.AddRange(mainTypeColumns.Select(x =>
                {
                    if (x.TrimStart().StartsWith("cmm,"))
                    {
                        x = "		ROW_NUMBER() OVER (ORDER BY id),";
                    }

                    return x;
                }));

                content.AddRange([
                    $"	FROM @p_{tableNameSimple}",
                ]);


                content.AddRange([
                     $"",
                     $"	INSERT INTO @v_{response.parentTable} (",
                ]);

                content.AddRange(parentTypeColumns);

                content.AddRange([
                    "	)",
                    $"	SELECT"
                ]);

                content.AddRange(parentTypeColumns.Select(x =>
                {
                    if (x.TrimStart().StartsWith("catalogo,"))
                    {
                        x = x.Replace("catalogo", "catalogo" + "_" + tableNameSimple.Split('_')[2]);
                    }

                    if (x.TrimStart().StartsWith("documento,"))
                    {
                        x = x.Replace("documento", "documento" + "_" + tableNameSimple.Split('_')[2]);
                    }

                    return x;
                }));

                content.AddRange([
                    $"	FROM @v_{tableNameSimple}",
                    $"",
                    $"	BEGIN TRANSACTION;",
                    $"",
                    $"	BEGIN TRY",
                    $"",
                    $"		INSERT INTO @v_{response.parentTable}",
                    $"		EXEC [ins_{response.parentTable}_bulk] @v_{response.parentTable}, @p_uid, @p_eid, @p_id_usuario",
                    $"",
                    $"		DELETE FROM @v_{response.parentTable} WHERE id IS NULL",
                ]);

            }
            else
                response.parentTable = null;

            response.parentInsert = content;

            return response;
        }

        private List<string> GenerateBulkUpdate(List<string> seedContent, string tableName, ref List<string> spRoot, ref List<string> allNewLines, bool hasCmm)
        {
            List<string> content = [];
            List<string> columns = [];
            (string? tableName, List<string> content) parentUpdate;
            bool hasParentTable;
            bool isParentTable;
            int indexFirstColumn;
            int indexLastColumn;
            string line;
            string column;

            string tableNameSimple = tableName.Replace('.', '_');

            isParentTable = tableName == "doc_documento" || tableName == "cat_catalogo";
            parentUpdate = GetParentUpdate(tableName, hasCmm);
            hasParentTable = !string.IsNullOrEmpty(parentUpdate.tableName);

            indexFirstColumn = seedContent.FindIndex(x => x.Contains($"[fechaCreacion]", StringComparison.CurrentCultureIgnoreCase)) + 1;
            indexLastColumn = seedContent.FindIndex(x => x.Contains($"VALUES", StringComparison.CurrentCultureIgnoreCase)) - 1;

            for (int i = indexFirstColumn; i <= indexLastColumn; i++)
            {
                line = seedContent[i];
                column = line.TrimStart().Replace(",", "").Replace(")", "");
                columns.Add($"			[{tableName}].{column} = ISNULL([source].{column.Replace('.', '_')}, [{tableName}].{column}),");
            }
            columns[^1] = columns[^1].TrimEnd()[..^1];

            content.AddRange([
                $"SET QUOTED_IDENTIFIER ON",
                $"GO",
                $"SET ANSI_NULLS ON",
                $"GO",
                $"",
                $"IF  EXISTS (SELECT 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[upd_{tableNameSimple}_bulk]') AND type in (N'P', N'PC'))DROP PROCEDURE [dbo].[upd_{tableNameSimple}_bulk]",
                $"GO",
                $"CREATE PROCEDURE [upd_{tableNameSimple}_bulk]",
                $"	@p_{tableNameSimple} AS typ_{tableNameSimple} READONLY,",
                $"	@p_uid varchar(500),",
                $"	@p_eid varchar(50),",
                $"	@p_id_usuario int",
                 $"AS",
                $"BEGIN",
            ]);

            if (hasCmm && !isParentTable)
                content.Add($"	DECLARE @v_ids AS typ_ids");

            content.AddRange(parentUpdate.content);

            if (parentUpdate.tableName is null)
            {
                if (!isParentTable)
                    content.AddRange([
                        "",
                        $"	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;",
                        "",
                        $"	BEGIN TRANSACTION;",
                    ]);

                content.AddRange([
                    "",
                    $"	BEGIN TRY",
                ]);
            }

            content.AddRange([
                "",
                $"		UPDATE [{tableName}]",
                $"		SET	[{tableName}].[id_usuario_modifico] = ISNULL(@p_id_usuario, [{tableName}].[id_usuario_modifico]),",
                $"			[{tableName}].[fechaModificacion] = GETDATE(),",
            ]);

            content.AddRange(columns);

            content.AddRange([
                $"		FROM [{tableName}]",
                $"			INNER JOIN @p_{tableNameSimple} [source]",
                $"		ON [{tableName}].id = [source].id",
                $"		WHERE ",
                $"			[{tableName}].eid = @p_eid AND",
                $"			[{tableName}].active = 1",
                ""
            ]);

            if (!isParentTable)
                content.AddRange([
                    $"		COMMIT TRANSACTION;",
                    $"",
                    $"	END TRY",
                    $"	BEGIN CATCH",
                    $"		ROLLBACK TRANSACTION;",
                    $"		THROW;",
                    $"	END CATCH;",
                    $"",
                ]);
            else
                content.AddRange([
                    $"	END TRY",
                    $"	BEGIN CATCH",
                    $"		THROW;",
                    $"	END CATCH;",
                    $"",
                ]);

            if (hasCmm && !isParentTable)
                content.AddRange([
                    $"	BEGIN TRY",
                    $"		INSERT INTO @v_ids",
                    $"		SELECT id",
                    $"		FROM @p_{tableNameSimple}",
                    "",
                    $"		EXEC upd_{tableNameSimple}_cmm @v_ids, @p_id_usuario, @p_eid",
                    $"	END TRY",
                    $"	BEGIN CATCH",
                    $"		PRINT 'ERROR [{tableName}]: ' + ERROR_MESSAGE();",
                    $"	END CATCH;",
                    $"",
                ]);

            content.AddRange([
                $"END",
                $"GO",
                $"SET QUOTED_IDENTIFIER OFF ",
                $"GO",
                $"SET ANSI_NULLS OFF",
                $"GO",
            ]);

            //allNewLines.AddRange(content);
            return content;
        }

        private (string? parentTable, List<string> parentInsert) GetParentUpdate(string tableName, bool hasCmm)
        {
            (string? parentTable, List<string> parentInsert) response;
            List<string> content = [];
            string column;
            int indexFirstColumn;
            int indexLastColumn;
            string tableNameSimple = tableName.Replace('.', '_');

            if ((tableName.StartsWith("doc_documento.") || tableName.StartsWith("cat_catalogo.")) && tableName.Replace('.', '_').Split('_').Length == 3)
            {
                response.parentTable = tableName.Split('.').First();
                List<string> parentTypeColumns = [];

                List<string> template = [.. File.ReadAllLines(Path.Combine(_destinyPath, "Types", response.parentTable, $"typ_{response.parentTable}.sql"))];
                List<string> parentColumns;
                int indexCmm;

                indexFirstColumn = template.FindIndex(x => x.Contains($"	active bit,", StringComparison.CurrentCultureIgnoreCase)) + 1;
                indexLastColumn = template.FindIndex(x => x.Contains($");", StringComparison.CurrentCultureIgnoreCase)) - 1;

                parentColumns = template.GetRange(indexFirstColumn, indexLastColumn - indexFirstColumn + 1);

                indexCmm = parentColumns.FindIndex(x => x.Contains("cmm ", StringComparison.CurrentCultureIgnoreCase));
                if (indexCmm > -1)
                    parentColumns.RemoveAt(indexCmm);

                if (parentColumns.Count > 0 && !parentColumns[^1].TrimEnd().EndsWith(','))
                    parentColumns[^1] = parentColumns[^1] + ",";

                parentTypeColumns.Add($"		id,");
                for (int i = 0; i < parentColumns.Count; i++)
                {
                    column = parentColumns[i].TrimStart().Split(' ').First() + (i < parentColumns.Count - 1 ? "," : "");

                    if (column.TrimStart().StartsWith("identificador") && tableName.StartsWith("doc_documento."))
                        continue;

                    parentTypeColumns.Add($"		{column}");
                }

                if (hasCmm)
                {
                    if (tableName.StartsWith("cat_catalogo."))
                        parentTypeColumns[^1] = parentTypeColumns[^1] + ",";
                    parentTypeColumns.Add($"		cmm");
                }

                content.AddRange([
                     $"	DECLARE @v_{response.parentTable} AS typ_{response.parentTable}",
                     $"",
                     $"	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;",
                     $"",
                     $"	INSERT INTO @v_{response.parentTable} (",
                ]);

                content.AddRange(parentTypeColumns);

                content.AddRange([
                    "	)",
                    $"	SELECT"
                ]);

                content.AddRange(parentTypeColumns.Select(x =>
                {
                    if (x.TrimStart().StartsWith("catalogo,"))
                    {
                        x = x.Replace("catalogo", "catalogo" + "_" + tableNameSimple.Split('_')[2]);
                    }

                    if (x.TrimStart().StartsWith("documento,"))
                    {
                        x = x.Replace("documento", "documento" + "_" + tableNameSimple.Split('_')[2]);
                    }

                    return x;
                }));

                content.AddRange([
                    $"	FROM @p_{tableNameSimple}",
                    "",
                    $"	BEGIN TRANSACTION;",
                    "",
                    $"	BEGIN TRY",
                    $"		EXEC [upd_{response.parentTable}_bulk] @v_{response.parentTable}, @p_uid, @p_eid, @p_id_usuario",
                ]);

            }
            else
                response.parentTable = null;

            response.parentInsert = content;

            return response;
        }

        private List<string> UpdateActiveSP(List<string> template, string tableName)
        {
            int index;

            const string QUOTED_IDENTIFIER = "SET QUOTED_IDENTIFIER";
            const string ANSI_NULLS = "SET ANSI_NULLS";

            index = template.FindIndex(x => x.Contains(QUOTED_IDENTIFIER));
            template[index] = template[index].Replace("OFF", "ON");

            index = template.FindIndex(x => x.Contains(ANSI_NULLS));
            template[index] = template[index].Replace("OFF", "ON");

            index = template.FindLastIndex(x => x.Contains(QUOTED_IDENTIFIER));
            template[index] = template[index].Replace("ON", "OFF");

            index = template.FindLastIndex(x => x.Contains(ANSI_NULLS));
            template[index] = template[index].Replace("ON", "OFF");

            return template;
        }

        private List<string> CleanInsertSP(List<string> template, string tableName, bool tableHasCmm)
        {
            bool hasCmm;
            bool IsParentOrHasParent;
            List<string> newSP;

            IsParentOrHasParent = IsParentOrHasParentTable(tableName, tableHasCmm);

            hasCmm = false;
            newSP = [];

            for (int i = 0; i < template.Count; i++)
            {
                string line = template[i];
                if (IsParentOrHasParent)
                {
                    if (hasCmm && line.Contains("@p_cmm varchar"))
                    {
                        if (!line.TrimEnd().EndsWith(','))
                            newSP[^1] = newSP[^1][..^1];

                        continue;
                    }

                    if (!hasCmm && line.Contains("@p_cmm varchar"))
                        hasCmm = true;

                    if (line.Contains("@p_identificador") || line.Contains("[identificador]"))
                    {
                        if (!line.TrimEnd().EndsWith(','))
                            newSP[^1] = newSP[^1][..^1];

                        continue;
                    }
                }

                if (line.Contains("(-1)", StringComparison.CurrentCultureIgnoreCase))
                    line = line.Replace("(-1)", "(MAX)");

                if (line.Contains("varbinary", StringComparison.CurrentCultureIgnoreCase))
                    line = line.Replace("varbinary", "varbinary(MAX)");

                newSP.Add(line);
            }

            return newSP;
        }

        private List<string> CleanUpdateSP(List<string> template, string tableName, bool tableHasCmm)
        {
            bool hasCmm;
            bool IsParentOrHasParent;
            List<string> newSP;

            IsParentOrHasParent = IsParentOrHasParentTable(tableName, tableHasCmm);

            hasCmm = false;
            newSP = [];

            for (int i = 0; i < template.Count; i++)
            {
                string line = template[i];

                if (IsParentOrHasParent)
                {
                    if (hasCmm && line.Contains("@p_cmm varchar"))
                    {
                        if (!line.TrimEnd().EndsWith(','))
                            newSP[^1] = newSP[^1][..^1];

                        continue;
                    }

                    if (!hasCmm && line.Contains("@p_cmm varchar"))
                        hasCmm = true;

                    if (line.Contains("@p_identificador") || line.Contains("[identificador]"))
                    {
                        if (!line.TrimEnd().EndsWith(','))
                            newSP[^1] = newSP[^1][..^1];

                        continue;
                    }
                }

                if (line.Contains("(-1)", StringComparison.CurrentCultureIgnoreCase))
                    line = line.Replace("(-1)", "(MAX)");

                if (line.Contains("varbinary", StringComparison.CurrentCultureIgnoreCase))
                    line = line.Replace("varbinary", "varbinary(MAX)");

                newSP.Add(line);
            }

            return newSP;
        }

        private bool IsParentOrHasParentTable(string tableName, bool hasCmm)
        {
            bool isParentTable;
            bool hasParentTable;
            (string? tableName, List<string> content) parentUpdate;

            isParentTable = tableName == "doc_documento" || tableName == "cat_catalogo";
            parentUpdate = GetParentUpdate(tableName, hasCmm);
            hasParentTable = !string.IsNullOrEmpty(parentUpdate.tableName);

            return isParentTable || hasParentTable;
        }
    }
}
