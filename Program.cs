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

        Console.WriteLine("Start ...");

        option = 0;

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
                entity = "GenConfiguracionCmm";

                fileModel = new FileModel()
                {
                    Path = $"{path}\\{entity}Object.cs",
                    Name = $"{entity}Object",
                    Extension = "cs"
                };

                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                rootPath: path,
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Microservice");


                response = controllerDataBaseGenerator.GenerateByEntity(entity, fileModel);

                break;

            case 2:
                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.Transverse\\SAMMAI.Transverse\\Models\\Objects",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Microservice");

                response = string.Join(Environment.NewLine, controllerDataBaseGenerator.GenerateForAllEntities());

                break;

            default:
                response = "Select an option";

                break;
        }



        Console.WriteLine($"Result: {response}");
        Console.WriteLine("End");
    }
}