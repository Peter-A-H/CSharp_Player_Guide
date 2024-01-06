namespace Game
{
    public record Cookie
    {
        public int OatmealRaisin { get; } = new Random().Next(10);
    }
}
