public class LogException
{
    public static void Log(Exception ex)
    {
        string filePath = "error_log.txt";
        StreamWriter writer = new StreamWriter(filePath, true);
        writer.WriteLine($"Timestamp: {DateTime.Now}");
        writer.WriteLine($"Exception: {ex.Message}");
        writer.WriteLine($"StackTrace: {ex.StackTrace}");
        writer.WriteLine(Environment.NewLine);
        writer.Close();
    }
}
