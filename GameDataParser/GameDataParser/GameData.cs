interface IGameData
{
    string Title { get; set; }
    int ReleaseYear { get; set; }
    float Rating { get; set; }
}
    public class GameData: IGameData
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public float Rating { get; set; }
    public override string ToString()
    {
        return $"Title: \"{Title}\"\nRelease Year: \"{ReleaseYear}\"\nRating: \"{Rating}\"";
    }
}
