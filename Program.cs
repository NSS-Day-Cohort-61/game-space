namespace Games
{
    class Program
    {
        static void Main(string[] args) 
        {
            VideoGame Hades = new VideoGame("Hades");
            Hades.Play();

            Sport Football = new Sport("American football");
            Football.BallType = "football";
            Football.Indoor = false;
            Football.MaxPlayers = 11;
            Football.MinPlayers = 11;
            Football.Price = 100000;
            Football.Rating = "Professional";

            Football.Play();
        }
    }
}