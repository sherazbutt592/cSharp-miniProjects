interface IGamePrinter
{
    void PrintGames(List<GameInformation> games);
}
class GamePrinter: IGamePrinter
{
    public void PrintGames(List<GameInformation> games)
    {
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Title}, released in: {game.ReleaseYear}, rating:{game.Rating}");
        }
    }
}
