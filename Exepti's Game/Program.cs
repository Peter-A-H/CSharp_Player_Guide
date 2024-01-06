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
    public List<int> PreviousNumbers { get; private set; } = [];
    public int PlayerType { get; private set; } = playerType;

    public void PickNumber()
    {
        Console.Write($"Player {PlayerType}, pick a number between 0 - 9: ");
        string? response = Console.ReadLine();

        if (response == null)
        {
            Console.Write("Null value entered.\n");
            PickNumber();
        }

        if (PreviousNumbers.Contains(Convert.ToInt32(response)))
        {
            Console.Write($"{response} has already been chosen before.\n");
            PickNumber();
        }

        ChosenNumber = Convert.ToInt32(response);
        PreviousNumbers.Add(ChosenNumber);
    }
}

public class CookieGame
{
    public bool InPlay { get; private set; } = true;
    public Player Player1 { get; private set; } = new(1);
    public Player Player2 { get; private set; } = new(2);
    public Cookie Cookie { get; private set; } = new();

    public void Run()
    {
        while (InPlay)
        {
            Player1.PickNumber();

            try
            {
                WasOatmealCookieChosen();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(Cookie.OatmealRaisin);
        }
    }

    public void WasOatmealCookieChosen()
    {
        if (Player1.ChosenNumber == Cookie.OatmealRaisin)
        {
            throw new Exception("Oatmeal raisin cookie was chosen!\n");
        }
    }
}