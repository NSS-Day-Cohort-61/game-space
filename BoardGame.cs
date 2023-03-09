namespace Games
{
    public class BoardGame : Game
    {
        public string Genre {get; set;}
        public int Size {get; set;}
        public int Time {get; set;}
        public BoardGame(string name) {
          Name = name;
        }
    }   
}
