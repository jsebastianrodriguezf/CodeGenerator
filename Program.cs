using CodeGenerator.BLL;
using CodeGenerator.Models;
using CodeGenerator.Proccess;
using static CodeGenerator.Enums.BaseEnums;

internal class Program
{
    private static void Main(string[] args)
    {
        string response;
        const string context = "SAMMAIPrincipalContext";
        const string rootPathSAMMAIDirectory = @"C:\Workspaces\GIT\SAMMAI";
        const string rootPathBaseWorkDirectory = @"C:\Workspaces\GIT\CodeGenerator";

        Console.WriteLine("Start ...");

        response = Execute(InputEnum.MapDataBase, context, rootPathBaseWorkDirectory, rootPathSAMMAIDirectory);

        Console.WriteLine($"Result: {response}");
        Console.WriteLine("End");
    }

    private static string Execute(InputEnum option, string context, string rootPathBaseWorkDirectory, string rootPathSAMMAIDirectory)
    {
        string response;
        string path;
        string entity;

        MapDataBase mapDataBase;
        SPsTableGenerator spsTableGenerator;
        I18NDictionaryGenerator i18NDictionaryGenerator;
        TranslateEFModelGenerator translateEFModelGenerator;
        DatabaseGenerator databaseGenerator;
        ControllerDataBaseGenerator controllerDataBaseGenerator;
        ControllerCoreDALGenerator controllerCoreDALGenerator;
        FolderTableGenerator folderTableGenerator;
        AlterTableGenerator alterTableGenerator;
        FileModel fileModel;

        const string baseResponseFolder = "DataBase";

        switch (option)
        {
            //Use this one to separate the View and SPs from the base script and generate the new Views and update SPs
            case InputEnum.SPsTableGenerator:
                spsTableGenerator = new SPsTableGenerator(
                    rootPath: Path.Combine(rootPathBaseWorkDirectory, "BaseScript"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "SPs"));

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateSPs());

                break;

            //Before to use this one, use the old SPs Generator, execute scripts and then generate the EF Core models
            //Use this one to generate all the classes, config, translate, mappers and constants, base on the database objects
            case InputEnum.MapDataBase:
                mapDataBase = new MapDataBase(
                    contextName: context,
                    rootPathModels: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "Models"),
                    rootPathSAMMAIDataBase: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DataBase"),
                    rootPathSAMMAICore: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Core", "SAMMAI.Core"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "MapDataBase"));

                response = mapDataBase.Execute();

                break;

            #region Singles
            case InputEnum.I18NDictionaryGenerator:
                i18NDictionaryGenerator = new I18NDictionaryGenerator(
                    contextName: context,
                    rootPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "Models"),
                    destinyPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "I18N"));

                i18NDictionaryGenerator.FullFillDictionary();
                response = "ok";

                break;

            case InputEnum.TranslateEFModelGenerator:
                translateEFModelGenerator = new TranslateEFModelGenerator(
                    conextName: context,
                    rootPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "Models"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "ModelsTranslated"));

                response = translateEFModelGenerator.Generate();

                break;

            case InputEnum.DatabaseGenerator:
                databaseGenerator = new DatabaseGenerator(
                    conextName: context,
                    rootPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "ModelsTranslated"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "Result"));

                response = databaseGenerator.Generate();

                break;

            case InputEnum.SingleControllerDataBaseGenerator:
                path = Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Transverse", "SAMMAI.Transverse", "Models", "Objects");
                entity = "SegPreference";

                fileModel = new FileModel()
                {
                    Path = $"{path}//{entity}Object.cs",
                    Name = $"{entity}Object",
                    Extension = "cs"
                };

                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                    rootPath: path,
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "Microservice"),
                    controllerPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DataBase", "Controllers"),
                    servicePath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DataBase", "Services", "Implementations"));


                response = controllerDataBaseGenerator.GenerateByEntity(entity, fileModel);

                break;

            case InputEnum.ControllerDataBaseGenerator:
                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                    rootPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Transverse", "SAMMAI.Transverse", "Models", "Objects"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "Microservice"),
                    controllerPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DataBase", "Controllers"),
                    servicePath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DataBase", "Services", "Implementations"));

                response = string.Join(Environment.NewLine, controllerDataBaseGenerator.GenerateForAllEntities());

                break;

            case InputEnum.SingleControllerCoreDALGenerator:
                path = Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Transverse", "SAMMAI.Transverse", "Models", "Objects");
                entity = "GenFormularioCatalogoEquipo";

                fileModel = new FileModel()
                {
                    Path = $"{path}//{entity}Object.cs",
                    Name = $"{entity}Object",
                    Extension = "cs"
                };

                controllerCoreDALGenerator = new ControllerCoreDALGenerator(
                    rootPath: path,
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "CoreDAL"),
                    controllerPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Core", "SAMMAI.Core", "Controllers"),
                    servicePath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Core", "SAMMAI.Core", "Services", "DAL", "Implementations"),
                    iServicePath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Core", "SAMMAI.Core", "Services", "DAL", "Interfaces"));


                response = controllerCoreDALGenerator.GenerateByEntity(entity, fileModel);

                break;

            case InputEnum.ControllerCoreDALGenerator:
                controllerCoreDALGenerator = new ControllerCoreDALGenerator(
                    rootPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Transverse", "SAMMAI.Transverse", "Models", "Objects"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "CoreDAL"),
                    controllerPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Core", "SAMMAI.Core", "Controllers"),
                    servicePath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Core", "SAMMAI.Core", "Services", "DAL", "Implementations"),
                    iServicePath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.Core", "SAMMAI.Core", "Services", "DAL", "Interfaces"));

                response = string.Join(Environment.NewLine, controllerCoreDALGenerator.GenerateForAllEntities());

                break;

            case InputEnum.FolderTableGenerator:
                folderTableGenerator = new FolderTableGenerator(
                    rootPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DBObjects", "Tables"),
                    configRootPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DataBase", "Repository", "Configurations"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "DBObjects", "Tables"));

                response = string.Join(Environment.NewLine, folderTableGenerator.GenerateFolders());

                break;

            case InputEnum.BaseSPsTableGenerator:
                spsTableGenerator = new SPsTableGenerator(
                    rootPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DBObjects", "Views"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "SPs"));

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateBasicViews());

                break;

            case InputEnum.AlterTableGenerator:
                alterTableGenerator = new AlterTableGenerator(
                    tablesRootPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DBObjects", "Tables"),
                    spsRootPath: Path.Combine(rootPathSAMMAIDirectory, "SAMMAI.DataBase", "SAMMAI.DBObjects", "StoreProcedures"),
                    destityPath: Path.Combine(rootPathBaseWorkDirectory, baseResponseFolder, "AlterTable"));

                response = string.Join(Environment.NewLine, alterTableGenerator.GenerateAlterScripts());

                break;
            #endregion

            default:
                response = "Select an option";
                break;
        }

        return response;
    }
}