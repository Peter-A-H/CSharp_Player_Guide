TicTacToeGame game = new();
Grid squares = new();
Player player1 = new('X');
Player player2 = new('O');
Player currentPlayer = player1;

game.ToggleGame();

while (game.InPlay)
{
    Console.WriteLine($"It is {currentPlayer.CrossOrNaught}'s turn.\n");
    squares.Draw();
    Console.WriteLine();

    Console.Write("What square do you want to play in? ");
    int chosenSquare = Convert.ToInt32(Console.ReadLine());

    squares.SetSquare(chosenSquare, currentPlayer);

    Console.WriteLine();

    if (TicTacToeGame.CheckForWinner(currentPlayer))
    {
        squares.Draw();
        Console.WriteLine($"\n{currentPlayer.CrossOrNaught} has won the game!");
        game.ToggleGame();
    };

    currentPlayer = (currentPlayer == player1) ? player2 : player1;
}

public class Player(char crossOrNaught)
{
    public char CrossOrNaught { get; private set; } = crossOrNaught;
}

public class Grid
{
    public static char[,] Squares { get; private set; } = new char[3, 3]
    {
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' }
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

public class TicTacToeGame
{
    public bool InPlay { get; private set; } = false;

    public void ToggleGame()
    {
        InPlay = !InPlay;
    }

    public static bool CheckForWinner(Player currentPlayer)
    {
        char[,] squares = Grid.Squares;

        if (squares[0, 0] == currentPlayer.CrossOrNaught &&
            squares[0, 1] == currentPlayer.CrossOrNaught &&
            squares[0, 2] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        if (squares[1, 0] == currentPlayer.CrossOrNaught &&
            squares[1, 1] == currentPlayer.CrossOrNaught &&
            squares[1, 2] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        if (squares[2, 0] == currentPlayer.CrossOrNaught &&
            squares[2, 1] == currentPlayer.CrossOrNaught &&
            squares[2, 2] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        if (squares[0, 0] == currentPlayer.CrossOrNaught &&
            squares[1, 0] == currentPlayer.CrossOrNaught &&
            squares[2, 0] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        if (squares[0, 1] == currentPlayer.CrossOrNaught &&
            squares[1, 1] == currentPlayer.CrossOrNaught &&
            squares[2, 1] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        if (squares[0, 2] == currentPlayer.CrossOrNaught &&
            squares[1, 2] == currentPlayer.CrossOrNaught &&
            squares[2, 2] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        if (squares[0, 0] == currentPlayer.CrossOrNaught &&
            squares[1, 1] == currentPlayer.CrossOrNaught &&
            squares[2, 2] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        if (squares[2, 0] == currentPlayer.CrossOrNaught &&
            squares[1, 1] == currentPlayer.CrossOrNaught &&
            squares[0, 2] == currentPlayer.CrossOrNaught)
        {
            return true;
        }

        return false;
    }
}