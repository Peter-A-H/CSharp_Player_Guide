using FountainOfObjects;
using System.Diagnostics;

Game game = CreateGame();
game.Run();

static Game CreateGame()
{
    int TOTAL_ROWS = 4;
    int TOTAL_COLS = 4;
    Map map = new(TOTAL_ROWS, TOTAL_COLS);

    int START_ROW = 0;
    int START_COL = 0;
    Location start = new(START_ROW, START_COL);

    Player player = new(start);
    return new Game(map, player);
}

namespace FountainOfObjects
{
    public class Game(Map map, Player player)
    {
        public bool InPlay { get; private set; } = true;
        public bool IsFountainEnabled { get; private set; }
        public Map Map { get; } = map;
        public Player Player { get; } = player;
        public Stopwatch Time { get; } = new();

        public void Run()
        {
            while (InPlay)
            {
                Time.Start();
                Player.Location.Current(this);
                if (!InPlay) break;
                Player.Location.Move(this);
            }
        }

        public void End()
        {
            InPlay = false;
            TimeInCaverns();
        }

        public void EnableFountain()
        {
            IsFountainEnabled = true;
            Console.WriteLine("You hear rushing waters from the Fountain of Objects. It has been reactivated!");
        }

        public bool HasPlayerEscaped()
        {
            if (IsFountainEnabled &&
                Player.Location.Row == Player.Location.Entrance[0] &&
                Player.Location.Column == Player.Location.Entrance[1])
            {
                return true;
            }

            return false;
        }

        public void TimeInCaverns()
        {
            Time.Stop();
            TimeSpan timespan = Time.Elapsed;

            string elapsedTime = $"{timespan.Minutes} minutes, {timespan.Seconds} seconds, {timespan.Milliseconds / 10} milliseconds";
            Console.WriteLine($"Time in caverns: {elapsedTime}");
        }
    }
}