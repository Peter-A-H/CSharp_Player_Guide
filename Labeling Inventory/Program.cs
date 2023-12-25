Pack pack = new(10, 15, 20);
Arrow arrow = new(1, 2.5f);
Sword sword = new(3, 5.5f);

Console.WriteLine($"Adding {arrow} to inventory");
pack.Add(arrow);
Console.WriteLine($"Adding {sword} to inventory");
pack.Add(sword);
Console.WriteLine(pack.ToString());

public class Pack(int totalItems, float maxWeight, float maxVolume)
{
    public InventoryItem[] Items { get; private set; } = new InventoryItem[totalItems];
    public int CurrentItemCount { get; private set; } = 0;
    public float CurrentWeight { get; private set; } = 0.0f;
    public float CurrentVolume { get; private set; } = 0.0f;

    private readonly int _totalItems = totalItems;
    private readonly float _maxWeight = maxWeight;
    private readonly float _maxVolume = maxVolume;

    public bool Add(InventoryItem item)
    {
        if (CurrentWeight + item.Weight > _maxWeight ||
            CurrentVolume + item.Volume > _maxVolume ||
            CurrentItemCount == _totalItems)
        {
            Console.WriteLine("Inventory is full.");
            return false;
        }

        Items[CurrentItemCount] = item;
        CurrentItemCount++;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;

        Console.WriteLine($"Item count: {CurrentItemCount}");
        Console.WriteLine($"Current weight: {CurrentWeight}");
        Console.WriteLine($"Current volume: {CurrentVolume}");
        Console.WriteLine();

        return true;
    }

    public override string ToString()
    {
        string packContains = "Pack containing";

        foreach (InventoryItem item in Items)
        {
            packContains += $" {item}";
        }

        return packContains;
    }
}

public class InventoryItem(float weight, float volume)
{
    public float Weight { get; private set; } = weight;
    public float Volume { get; private set; } = volume;
}

public class Arrow(float weight, float volume) : InventoryItem(weight, volume)
{
    public override string ToString() => "arrow";
}

public class Rope(float weight, float volume) : InventoryItem(weight, volume)
{
    public override string ToString() => "rope";
}

public class Water(float weight, float volume) : InventoryItem(weight, volume)
{
    public override string ToString() => "water";
}

public class Sword(float weight, float volume) : InventoryItem(weight, volume)
{
    public override string ToString() => "sword";
}

public class Food(float weight, float volume) : InventoryItem(weight, volume)
{
    public override string ToString() => "food";
}
