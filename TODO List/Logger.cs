class Logger
{
    public static void Log(Exception ex)
    {
        using (var writer = new StreamWriter("log.txt", true))
        {
            writer.WriteLine($"{DateTime.Now}: {ex.Message} \n {ex.StackTrace} \n");
        }
    }
}
