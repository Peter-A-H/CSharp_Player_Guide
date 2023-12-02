int[,] matrix = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write(matrix[row, column] + " ");
    }

    Console.WriteLine();
}
