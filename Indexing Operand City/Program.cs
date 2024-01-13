BlockCoordinate coords = new(4, 3);
BlockOffset offset = new(2, 0);
Console.WriteLine($"Coords - row: {coords[0]}, column: {coords[1]}");
Console.WriteLine(coords + offset);
Console.WriteLine(coords + Direction.North);

public record BlockCoordinate(int Row, int Column)
{
    public int this[int index]
    {
        get
        {
            if (index == 0) return Row;
            else return Column;
        }
    }

    public static BlockCoordinate operator +(BlockCoordinate coordinate, BlockOffset offset)
    {
        return new BlockCoordinate(coordinate.Row + offset.RowOffset,
                                   coordinate.Column + offset.ColumnOffset);
    }

    public static BlockCoordinate operator +(BlockCoordinate coordinate, Direction direction)
    {
        return coordinate + (direction switch
        {
            Direction.North => new BlockOffset(-1, 0),
            Direction.South => new BlockOffset(+1, 0),
            Direction.West => new BlockOffset(0, -1),
            Direction.East => new BlockOffset(0, +1),
            _ => throw new NotImplementedException()
        });
    }
}

public record BlockOffset(int RowOffset, int ColumnOffset);
public enum Direction { North, East, South, West }