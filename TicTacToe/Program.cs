var game = new TicTacToeGame();
var board = new Grid();
var player1 = new Player('X');
var player2 = new Player('O');
var currentPlayer = player1;

game.Run();

while (game.InPlay)
{
    Console.WriteLine($"It is {currentPlayer.CrossOrNaught}'s turn.");
    board.Draw();

    Console.Write("What square do you want to play in? ");
    int chosenSquare = Convert.ToInt32(Console.ReadLine());

    board.SetSquare(chosenSquare, currentPlayer);
    currentPlayer = (currentPlayer == player1) ? player2 : player1;

    Console.Clear();
}

public class Player(char crossOrNaught)
{
    public char CrossOrNaught { get; private set; } = crossOrNaught;
}

public class Grid
{
    public char[,] Squares { get; private set; } = new char[3, 3]
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    public void Draw()
    {
        Console.WriteLine($" {Squares[0, 0]} | {Squares[0, 1]} | {Squares[0, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Squares[1, 0]} | {Squares[1, 1]} | {Squares[1, 2]} ");
        Console.WriteLine($"---+---+---");
        Console.WriteLine($" {Squares[2, 0]} | {Squares[2, 1]} | {Squares[2, 2]} ");
    }

    public void SetSquare(int squareChoice, Player currentPlayer)
    {
        switch (squareChoice)
        {
            case 1:
                Squares[0, 0] = currentPlayer.CrossOrNaught;
                break;
            case 2:
                Squares[0, 1] = currentPlayer.CrossOrNaught;
                break;
            case 3:
                Squares[0, 2] = currentPlayer.CrossOrNaught;
                break;
            case 4:
                Squares[1, 0] = currentPlayer.CrossOrNaught;
                break;
            case 5:
                Squares[1, 1] = currentPlayer.CrossOrNaught;
                break;
            case 6:
                Squares[1, 2] = currentPlayer.CrossOrNaught;
                break;
            case 7:
                Squares[2, 0] = currentPlayer.CrossOrNaught;
                break;
            case 8:
                Squares[2, 1] = currentPlayer.CrossOrNaught;
                break;
            case 9:
                Squares[2, 2] = currentPlayer.CrossOrNaught;
                break;
            default:
                throw new IndexOutOfRangeException("1-9 required.");
        }
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

    public void CheckForWinner()
    {

    }

    // all 8 possible win conditions
}