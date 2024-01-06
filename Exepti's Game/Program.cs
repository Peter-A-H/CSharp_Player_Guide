using CustomExceptions;
using Game;

CookieGame game = CreateGame();
game.Run();

static CookieGame CreateGame() => new();

namespace Game
{
    public class CookieGame
    {
        public static Player Player1 { get; private set; } = new(1);
        public static Player Player2 { get; private set; } = new(2);
        public Player CurrentPlayer { get; private set; } = Player1;
        public Cookie Cookie { get; private set; } = new();

        public void Run()
        {
            while (true)
            {
                try
                {
                    CurrentPlayer.PickNumber();
                }
                catch (ValueOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                    CurrentPlayer.PickNumber();
                }
                catch (DuplicateValueException exception)
                {
                    Console.WriteLine(exception.Message);
                    CurrentPlayer.PickNumber();
                }

                try
                {
                    WasOatmealCookieChosen();
                }
                catch (OatmealCookieException exception)
                {
                    Console.WriteLine(exception.Message);
                    Player winner = CurrentPlayer == Player1 ? Player2 : Player1;
                    Console.WriteLine($"Player {winner.PlayerType} has won the game!");
                    break;
                }

                CurrentPlayer = CurrentPlayer == Player1 ? Player2 : Player1;
            }
        }

        public void WasOatmealCookieChosen()
        {
            if (CurrentPlayer.ChosenNumber == Cookie.OatmealRaisin)
            {
                throw new OatmealCookieException("Oatmeal raisin cookie was chosen!");
            }
        }
    }
}