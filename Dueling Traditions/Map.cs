namespace FountainOfObjects;

public struct Map
{
    public RoomType[,]? Grid { get; private set; }

    public Map(int rows, int columns)
    {
        Grid = new RoomType[rows, columns];
        Grid[0, 0] = RoomType.Entrance;
        Grid[0, 2] = RoomType.Fountain;
    }
}
