using GenerarCodigo;

internal class Program
{
    private static void Main(string[] args)
    {
        string response;
        DatabaseGenerator databaseGenerator;
        
        Console.WriteLine("Start ...");

        databaseGenerator = new DatabaseGenerator(
            conextName: "SAMMAIContext",
            rootPath: "C:\\Workspaces\\GenerarCodigo\\DataBase\\Models",
            destityPath: "C:\\Workspaces\\GenerarCodigo\\DataBase\\Result");

        response = databaseGenerator.Generate();

        Console.WriteLine($"Result: {response}");
        Console.WriteLine("End");
    }
}