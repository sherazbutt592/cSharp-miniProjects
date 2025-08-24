using System.Text.Json;
interface IRepository
{
    void WriteCollectionToFile(List<Todo> content);
    List<Todo> ReadFromFile();
}
class Repository : IRepository
{
    private readonly string _fileName;

    public Repository(string fileName)
    {
        _fileName = fileName;
    }

    public void WriteCollectionToFile(List<Todo> content)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(content);
            File.WriteAllText(_fileName, jsonString);
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }
    public List<Todo> ReadFromFile()
    {
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("File does not exist. Please create a file first.");
            return new List<Todo>();
        }

        string jsonString = File.ReadAllText(_fileName);
        if (string.IsNullOrEmpty(jsonString))
        {
            return new List<Todo>();
        }
        return JsonSerializer.Deserialize<List<Todo>>(jsonString) ?? new List<Todo>();
    }
}
