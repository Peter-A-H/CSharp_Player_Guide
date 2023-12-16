Color[] colors = [Color.Red, Color.Green, Color.Blue, Color.Yellow];
Rank[] ranks = [Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand];

foreach (Color color in colors)
{
    foreach (Rank rank in ranks)
    {
        Card card = new(rank, color);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}

public class Card(Rank rank, Color color)
{
    public Rank Rank { get; } = rank;
    public Color Color { get; } = color;

    public bool IsSymbol => Rank == Rank.Ampersand || Rank == Rank.Caret || Rank == Rank.DollarSign || Rank == Rank.Percent;
    public bool IsNumber => !IsSymbol;
}

public enum Color { Red, Green, Blue, Yellow }
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }
