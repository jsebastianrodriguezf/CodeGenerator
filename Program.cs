using CodeGenerator.BLL;
using CodeGenerator.Models;
using CodeGenerator.Proccess;
using static CodeGenerator.Enums.BaseEnums;

internal class Program
{
    private static void Main(string[] args)
    {
        string response;

        Console.WriteLine("Start ...");

        response = Execute(InputEnum.MapDataBase);

        Console.WriteLine($"Result: {response}");
        Console.WriteLine("End");
    }

    private static string Execute(InputEnum option)
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

        switch (option)
        {
            //Use this one to separate the View and SPs from the base script and generate the new Views and update SPs
            case InputEnum.SPsTableGenerator:
                spsTableGenerator = new SPsTableGenerator(
                    rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\BaseScript",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\SPs");

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateSPs());

                break;

            //Before to use this one, use the old SPs Generator, execute scripts and then generate the EF Core models
            //Use this one to generate all the classes, config, translate, mappers and constants, base on the database objects
            case InputEnum.MapDataBase:
                mapDataBase = new MapDataBase(
                    contextName: "SAMMAIPrincipalContext",
                    rootPathModels: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Models",
                    rootPathSAMMAIDataBase: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase",
                    rootPathSAMMAICore: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Core\\SAMMAI.Core",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\MapDataBase");

                response = mapDataBase.Execute();

                break;

            #region Singles
            case InputEnum.I18NDictionaryGenerator:
                i18NDictionaryGenerator = new I18NDictionaryGenerator(
                    contextName: "SAMMAIPrincipalContext",
                    rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Models",
                    destinyPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\I18N");

                i18NDictionaryGenerator.FullFillDictionary();
                response = "ok";

                break;

            case InputEnum.TranslateEFModelGenerator:
                translateEFModelGenerator = new TranslateEFModelGenerator(
                    conextName: "SAMMAIPrincipalContext",
                    rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Models",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\ModelsTranslated");

                response = translateEFModelGenerator.Generate();

                break;

            case InputEnum.DatabaseGenerator:
                databaseGenerator = new DatabaseGenerator(
                    conextName: "SAMMAIPrincipalContext",
                    rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\ModelsTranslated",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Result");

                response = databaseGenerator.Generate();

                break;

            case InputEnum.SingleControllerDataBaseGenerator:
                path = "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Transverse\\SAMMAI.Transverse\\Models\\Objects";
                entity = "SegPreference";

                fileModel = new FileModel()
                {
                    Path = $"{path}\\{entity}Object.cs",
                    Name = $"{entity}Object",
                    Extension = "cs"
                };

                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                    rootPath: path,
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Microservice",
                    controllerPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Controllers",
                    servicePath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Services\\Implementations");


                response = controllerDataBaseGenerator.GenerateByEntity(entity, fileModel);

                break;

            case InputEnum.ControllerDataBaseGenerator:
                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                    rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Transverse\\SAMMAI.Transverse\\Models\\Objects",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Microservice",
                    controllerPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Controllers",
                    servicePath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Services\\Implementations");

                response = string.Join(Environment.NewLine, controllerDataBaseGenerator.GenerateForAllEntities());

                break;

            case InputEnum.SingleControllerCoreDALGenerator:
                path = "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Transverse\\SAMMAI.Transverse\\Models\\Objects";
                entity = "GenFormularioCatalogoEquipo";

                fileModel = new FileModel()
                {
                    Path = $"{path}\\{entity}Object.cs",
                    Name = $"{entity}Object",
                    Extension = "cs"
                };

                controllerCoreDALGenerator = new ControllerCoreDALGenerator(
                    rootPath: path,
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\CoreDAL",
                    controllerPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Core\\SAMMAI.Core\\Controllers",
                    servicePath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Core\\SAMMAI.Core\\Services\\DAL\\Implementations",
                    iServicePath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Core\\SAMMAI.Core\\Services\\DAL\\Interfaces");


                response = controllerCoreDALGenerator.GenerateByEntity(entity, fileModel);

                break;

            case InputEnum.ControllerCoreDALGenerator:
                controllerCoreDALGenerator = new ControllerCoreDALGenerator(
                    rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Transverse\\SAMMAI.Transverse\\Models\\Objects",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\CoreDAL",
                    controllerPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Core\\SAMMAI.Core\\Controllers",
                    servicePath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Core\\SAMMAI.Core\\Services\\DAL\\Implementations",
                    iServicePath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Core\\SAMMAI.Core\\Services\\DAL\\Interfaces");

                response = string.Join(Environment.NewLine, controllerCoreDALGenerator.GenerateForAllEntities());

                break;

            case InputEnum.FolderTableGenerator:
                folderTableGenerator = new FolderTableGenerator(
                    rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\Tables",
                    configRootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Repository\\Configurations",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\DBObjects\\Tables");

                response = string.Join(Environment.NewLine, folderTableGenerator.GenerateFolders());

                break;

            case InputEnum.BaseSPsTableGenerator:
                spsTableGenerator = new SPsTableGenerator(
                    rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\Views",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\SPs");

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateBasicViews());

                break;

            case InputEnum.AlterTableGenerator:
                alterTableGenerator = new AlterTableGenerator(
                    tablesRootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\Tables",
                    spsRootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\StoreProcedures",
                    destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\AlterTable");

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