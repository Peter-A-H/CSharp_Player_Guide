CookieGame game = CreateGame();
game.Run();

static CookieGame CreateGame() => new();

public record Cookie
{
    public int OatmealRaisin { get; } = new Random().Next(10);
}

public class Player(int playerType)
{
    public int ChosenNumber { get; private set; }
    public int PlayerType { get; private set; } = playerType;
    public static List<int> PreviousNumbers { get; private set; } = [];

    public void PickNumber()
    {
        Console.Write($"Player {PlayerType}, pick a number between 0-9: ");
        string? response = Console.ReadLine();
        if (response == null) return;
        int chosenNumber = 0;

        try
        {
            chosenNumber = Convert.ToInt32(response);
        }
        catch (FormatException exception)
        {
            Console.WriteLine(exception.Message);
        }

        if (chosenNumber < 0 || chosenNumber > 9)
        {
            throw new ValueOutOfRangeException("Please enter a number between 0-9.\n");
        }

        if (PreviousNumbers.Contains(chosenNumber))
        {
            throw new DuplicateValueException($"{response} has already been chosen before.");
        }

        Console.WriteLine($"Chosen number: {chosenNumber}");
        ChosenNumber = chosenNumber;
        PreviousNumbers.Add(ChosenNumber);
    }
}

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
            Console.WriteLine($"Cookie: {Cookie.OatmealRaisin}");

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

public class OatmealCookieException(string message) : Exception(message) { }
public class ValueOutOfRangeException(string message) : Exception(message) { }
public class DuplicateValueException(string message) : Exception(message) { }
