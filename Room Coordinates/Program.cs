Coordinate a = new(3, 3);
Coordinate b = new(2, 3);
Coordinate c = new(2, 2);

Console.WriteLine(Coordinate.IsAdjacent(a, b));
Console.WriteLine(Coordinate.IsAdjacent(b, c));
Console.WriteLine(Coordinate.IsAdjacent(a, c));

public readonly struct Coordinate(int row, int column)
{
    public int Row { get; } = row;
    public int Column { get; } = column;

    public static bool IsAdjacent(Coordinate a, Coordinate b)
    {
        int rowChange = (a.Row - b.Row) * -1;
        int columnChange = (a.Column - b.Column) * -1;

        if (rowChange <= 1 && columnChange == 0) return true;
        if (columnChange <= 1 && rowChange == 0) return true;

        return false;
    }
}