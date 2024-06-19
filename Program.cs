using CodeGenerator;
using CodeGenerator.Models;
using GenerarCodigo;
using static CodeGenerator.Enums.BaseEnums;

internal class Program
{
    private static void Main(string[] args)
    {
        string response;
        InputEnum option;
        DatabaseGenerator databaseGenerator;
        ControllerDataBaseGenerator controllerDataBaseGenerator;
        ControllerCoreDALGenerator controllerCoreDALGenerator;
        FolderTableGenerator folderTableGenerator;
        SPsTableGenerator spsTableGenerator;
        FileModel fileModel;
        string path;
        string entity;

        Console.WriteLine("Start ...");

        option = InputEnum.SPsTableGenerator;

        switch (option)
        {
            case InputEnum.DatabaseGenerator:
                databaseGenerator = new DatabaseGenerator(
                conextName: "SAMMAIPrincipalContext",
                rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Models",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Result");

                response = databaseGenerator.Generate();

                break;

            case InputEnum.SingleControllerDataBaseGenerator:
                path = "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Transverse\\SAMMAI.Transverse\\Models\\Objects";
                entity = "GenFormularioCatalogoEquipo";

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

            case InputEnum.FolderTableGenerator:
                folderTableGenerator = new FolderTableGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\Tables",
                configRootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Repository\\Configurations",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\DBObjects\\Tables");

                response = string.Join(Environment.NewLine, folderTableGenerator.GenerateFolders());

                break;

            case InputEnum.SPsTableGenerator:
                spsTableGenerator = new SPsTableGenerator(
                rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\BaseScript",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\SPs");

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateSPs());

                break;

            case InputEnum.BaseSPsTableGenerator:
                spsTableGenerator = new SPsTableGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\Views",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\SPs");

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateBasicViews());

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

            default:
                response = "Select an option";

                break;
        }

        Console.WriteLine($"Result: {response}");
        Console.WriteLine("End");
    }
}