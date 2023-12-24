Pack pack = new(10, 15, 20);

if (pack.Add(new Arrow(5, 10)))
{
    Console.WriteLine(pack.CurrentItemCount);
    Console.WriteLine(pack.CurrentWeight);
    Console.WriteLine(pack.CurrentVolume);
}
else
{
    Console.WriteLine("Inventory is full");
}

public class Pack(int totalItems, float maxWeight, float maxVolume)
{
    public InventoryItem[] Items { get; private set; } = new InventoryItem[totalItems];
    public float CurrentItemCount { get; private set; } = 0;
    public float CurrentWeight { get; private set; } = 0;
    public float CurrentVolume { get; private set; } = 0;

    private readonly int TotalItems = totalItems;
    private readonly float MaxWeight = maxWeight;
    private readonly float MaxVolume = maxVolume;
    private int Count = 0;

    public bool Add(InventoryItem item)
    {
        if (CurrentWeight + item.Weight > MaxWeight ||
            CurrentVolume + item.Volume > MaxVolume ||
            CurrentItemCount == TotalItems)
        {
            return false;
        }

        Items[Count] = item;
        CurrentItemCount++;
        CurrentWeight += item.Weight;
        CurrentVolume += item.Volume;
        Count++;

        return true;
    }
}

public class InventoryItem(float weight, float volume)
{
    public float Weight { get; private set; } = weight;
    public float Volume { get; private set; } = volume;
}


public class Arrow(float weight, float volume) : InventoryItem(weight, volume) { }

public class Rope(float weight, float volume) : InventoryItem(weight, volume) { }

public class Water(float weight, float volume) : InventoryItem(weight, volume) { }

public class Sword(float weight, float volume) : InventoryItem(weight, volume) { }

public class Food(float weight, float volume) : InventoryItem(weight, volume) { }
