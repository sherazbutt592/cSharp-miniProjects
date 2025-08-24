namespace GameDataParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new Repository();
            IUserInteractions userInteractions = new UserInteractions();
            DataParser parser = new DataParser(userInteractions, repository);
            try
            {
                parser.Parse();
            }
            catch(Exception ex) {

                Logger.Log(ex);
            }
        }
    }
}