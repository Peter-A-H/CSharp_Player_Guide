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