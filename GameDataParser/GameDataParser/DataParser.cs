using System.Text.Json;

public class DataParser
{
    private readonly IUserInteractions _userInteractions;
    private readonly IRepository _repository;
    public DataParser(IUserInteractions userInteractions, IRepository repository)
    {
        _userInteractions = userInteractions;
        _repository = repository;
    }
    public void Parse()
    {
        _userInteractions.ShowMessage("Enter the name of the file you want to read: ");
        string fileName = _userInteractions.ReadFileName();
        if (IsValid(fileName))
        {
            List<GameData> gameData = _repository.ReadGameData(fileName);
            _userInteractions.PrintGameData(gameData);
        }
        else
        {
            _userInteractions.PrintInvalidGameData(File.ReadAllText(fileName));
        }
    }

    private bool IsValid(string fileName)
    {
        string content = File.ReadAllText(fileName);
        try
        {
            JsonSerializer.Deserialize<List<GameData>>(content);
            return true;
        }
        catch (JsonException)
        {
            _userInteractions.ShowMessage("File content is not valid JSON.");
            return false;
        }
    }
}