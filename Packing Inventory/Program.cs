Pack pack = new(10, 15, 20);

public class Pack(int totalItems, float maxWeight, float maxVolume)
{
    public InventoryItem[] Items { get; set; } = new InventoryItem[totalItems];
    public int TotalItems = totalItems;
    public float MaxWeight = maxWeight;
    public float MaxVolume = maxVolume;

    public bool Add(InventoryItem item)
    {

    }
}

public class InventoryItem(float weight, float volume)
{
    public float Weight { get; set; } = weight;
    public float Volume { get; set; } = volume;
}


public class Arrow(float weight, float volume) : InventoryItem(weight, volume)
{
}

public class Rope(float weight, float volume) : InventoryItem(weight, volume)
{

}

public class Water(float weight, float volume) : InventoryItem(weight, volume)
{

}

public class Sword(float weight, float volume) : InventoryItem(weight, volume)
{

}

public class Food(float weight, float volume) : InventoryItem(weight, volume)
{

}