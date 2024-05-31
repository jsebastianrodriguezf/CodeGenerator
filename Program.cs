using CodeGenerator;
using CodeGenerator.Models;
using GenerarCodigo;

internal class Program
{
    private static void Main(string[] args)
    {
        string response;
        int option;
        DatabaseGenerator databaseGenerator;
        ControllerDataBaseGenerator controllerDataBaseGenerator;
        FolderTableGenerator folderTableGenerator;
        SPsTableGenerator spsTableGenerator;

        Console.WriteLine("Start ...");

        option = 5;

        switch (option)
        {
            case 0:
                databaseGenerator = new DatabaseGenerator(
                conextName: "SAMMAIPrincipalContext",
                rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Models",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Result");

                response = databaseGenerator.Generate();

                break;

            case 1:
                FileModel fileModel;
                string path;
                string entity;

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

            case 2:
                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Transverse\\SAMMAI.Transverse\\Models\\Objects",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Microservice",
                controllerPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Controllers",
                servicePath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Services\\Implementations");

                response = string.Join(Environment.NewLine, controllerDataBaseGenerator.GenerateForAllEntities());

                break;

            case 3:
                folderTableGenerator = new FolderTableGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\Tables",
                configRootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Repository\\Configurations",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\DBObjects\\Tables");

                response = string.Join(Environment.NewLine, folderTableGenerator.GenerateFolders());

                break;

            case 4:
                spsTableGenerator = new SPsTableGenerator(
                rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\BaseScript",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\SPs");

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateSPs());

                break;

            case 5:
                spsTableGenerator = new SPsTableGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DBObjects\\Views",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\SPs");

                response = string.Join(Environment.NewLine, spsTableGenerator.GenerateBasicViews());

                break;

            default:
                response = "Select an option";

                break;
        }



        Console.WriteLine($"Result: {response}");
        Console.WriteLine("End");
    }
}