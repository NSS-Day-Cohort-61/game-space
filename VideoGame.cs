namespace Games
{
    public class VideoGame : Game
    {
        public string Console {get; set;}
        public string Rating {get; set;}
        public string Genre {get; set;}

        public VideoGame(string name) {
          Name = name;
        }
    }
}
