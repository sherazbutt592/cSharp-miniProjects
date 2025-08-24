public interface IUserInteractions
{
    void PrintGameData(List<GameData> gameData);
    void PrintInvalidGameData(string v);
    string ReadFileName();
    void ShowMessage(string message);
}
public class UserInteractions : IUserInteractions
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadFileName()
    {
        string name;
        while (true)
        {
            if(string.IsNullOrEmpty(name = Console.ReadLine()))
            {
                ShowMessage("File name cannot be empty. Please enter a valid file name: ");
                continue;
            }
            if (File.Exists(name))
            {
                return name;
            }
            else
            {
                ShowMessage("File does not exist. Please enter a valid file name: ");
                continue;
            }
        }
    }

    public void PrintGameData(List<GameData> gameData)
    {
        foreach (var game in gameData)
        {
            Console.WriteLine(game);
        }
    }

    public void PrintInvalidGameData(string v)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(v);
        Console.ForegroundColor = previousColor;
    }
}