using System.Text.Json;

class Repository
{
    public static void ReadGamesFileAndPrint(string fileName, IJsonValidator validator, IGamePrinter printer)
    {
        var jsonString = File.ReadAllText(fileName);
        if (validator.IsValidJson(jsonString))
        {
            var games = JsonSerializer.Deserialize<List<GameInformation>>(jsonString);
            if(games == null || games.Count == 0)
            {
                Console.WriteLine("No games found or the file is empty.");
                return;
            }
            printer.PrintGames(games);
        }
        else
        {
            Console.WriteLine($"JSON in the {fileName} is not in a valid format.\nJson body:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(File.ReadAllText(fileName));
            Console.ResetColor();
            return ;
        }
    }
}
