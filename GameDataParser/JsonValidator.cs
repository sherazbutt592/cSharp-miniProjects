using System.Text.Json;
interface IJsonValidator
{
    bool IsValidJson(string jsonString);
}
public class JsonValidator: IJsonValidator
{
    public bool IsValidJson(string jsonString)
    {
        try
        {
            JsonDocument.Parse(jsonString);
            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}