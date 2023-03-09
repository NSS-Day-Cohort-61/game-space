namespace Games
{
    public class DrinkingGame : Game 
    {
        public int NumOfShots {get; set;}
        public new bool Indoor {get; set;}
        public DrinkingGame(string name) {
          Name = name;
        }
    }
}
