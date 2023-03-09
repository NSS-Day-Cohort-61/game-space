namespace Games
{
    public class Sport : Game
    {
        public string BallType { get; set; }
        public bool Indoor {get; set;}
        public string Rating {get; set;}

        // constructor method
        public Sport(string name) {
          Name = name;
        }

        public override void Play () {
          Console.WriteLine($"Playing {this.Name} with a {this.BallType}!");
        }
    }
}
