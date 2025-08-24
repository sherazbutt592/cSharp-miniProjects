using System.Text.Json;

public interface IRepository
{
    List<GameData> ReadGameData(string filePath);
}
public class Repository : IRepository
{
    public List<GameData> ReadGameData(string filePath)
    {
        try
        {
            List<GameData> contents = JsonSerializer.Deserialize<List<GameData>>(File.ReadAllText(filePath));
            return contents;
        }
        catch (JsonException ex)
        {
            Logger.Log(ex);
            throw;
        }
        catch (IOException ex)
        {
            Logger.Log(ex);
            throw;
        }
    }
}