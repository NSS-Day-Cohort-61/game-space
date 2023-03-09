namespace Games
{
    public class Game  
    {
        public int MaxPlayers { get; set; }
        public int MinPlayers { get; set; }
        public string Name { get; set; }
        public double Price {get; set;}

        public virtual void Play()
        {
          Console.WriteLine("Playing a game!");
        }
    }
}
