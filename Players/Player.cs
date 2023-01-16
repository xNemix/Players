namespace Players
{
    public class Player {
        private int _points;
        private string _name;
        private Random _random;

        public Player(string name, int points, Random random)
        {
            _name = name;
            _points = points;
            _random = random;
        }

        public void Play(Player player)
        {
            var getRandomWinner = _random.Next(2) == 0;
            var givePointsToWinner = getRandomWinner == true ? _points++ : player._points++;
            var takePointsFromLoser = getRandomWinner == false ? _points-- : player._points--;
        }

        public void ShowNameAndPoints()
        {
            var outputText = $"Spiller: {_name} har {_points} poeng!";
            Console.WriteLine(outputText);
        }
    }
}
