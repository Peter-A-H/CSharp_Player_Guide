var game = new TicTacToeGame();
var player1 = new Player('X');
var player2 = new Player('O');

game.Run();

while (game.InPlay)
{
    Grid.Draw();
}

public class Player(char crossOrNaught)
{
    public char CrossOrNaught { get; private set; } = crossOrNaught;
}

static class Grid
{
    static public void Draw()
    {
        Console.WriteLine($" X | O | X ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" X | O | O ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" X | 0 | X ");
    }
}

public class TicTacToeGame
{
    public bool InPlay { get; private set; }

    public void Run()
    {
        InPlay = true;
    }

    public void End()
    {
        InPlay = false;
    }
}