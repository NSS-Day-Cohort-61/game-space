namespace Games
{
    public class CardGame : Game
    {
        public string NumOfCards {get; set;}
        public int Time {get; set;}
        public CardGame(string name) {
          Name = name;
        }
    }
}
