using CodeGenerator;
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

        option = 3;

        switch (option)
        {
            case 0:
                databaseGenerator = new DatabaseGenerator(
                conextName: "SAMMAIContext",
                rootPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Models",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Result");

                response = databaseGenerator.Generate();

                break;

            case 2:
                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Repository\\Entities",
                destityPath: "C:\\Workspaces\\GIT\\CodeGenerator\\DataBase\\Microservice");

                string entity = "GenTipoDato";

                response = controllerDataBaseGenerator.GenerateByEntity(entity);

                break;

            case 3:
                controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                rootPath: "C:\\Workspaces\\GIT\\SAMMAI\\SAMMAI.DataBase\\SAMMAI.DataBase\\Repository\\Entities",
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