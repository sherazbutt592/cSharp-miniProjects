public class Logger
{
    public static void Log(Exception ex)
    {
        using (StreamWriter writer = new StreamWriter("error.log", true))
        {
            writer.WriteLine($"[{DateTime.Now}] {ex.Message}");
            writer.WriteLine(ex.StackTrace);
            writer.WriteLine();
        }
    }
}
