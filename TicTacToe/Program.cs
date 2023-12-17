var game = new TicTacToeGame();
var board = new Grid();
var player1 = new Player('X');
var player2 = new Player('O');

game.Run();

board.Draw();
while (game.InPlay)
{
}

public class Player(char crossOrNaught)
{
    public char CrossOrNaught { get; private set; } = crossOrNaught;
}

public class Grid
{
    public char[,] Squares { get; private set; } = new char[3, 3]
    {
        { 'X', 'O', 'X' },
        { 'O', 'X', 'O' },
        { 'O', 'O', 'O' }
    };

    public void Draw()
    {
        Console.WriteLine($" {Squares[0, 0]} | {Squares[0, 1]} | {Squares[0, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Squares[1, 0]} | {Squares[1, 1]} | {Squares[1, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Squares[2, 0]} | {Squares[2, 1]} | {Squares[2, 2]} ");
    }
}

// Store a 3x3 matrix for the win conditions
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