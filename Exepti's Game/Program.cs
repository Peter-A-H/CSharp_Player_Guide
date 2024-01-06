Cookie cookie = new();
Console.WriteLine(cookie.OatmealRaisin);

public record Cookie
{
    public int OatmealRaisin { get; } = new Random().Next(10);
}