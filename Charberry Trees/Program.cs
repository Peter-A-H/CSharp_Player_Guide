CharberryTree tree = new();
Notifier notify = new(tree);
Harvester harvest = new(tree);

while (true)
{
    tree.MaybeGrow();
}

public class CharberryTree
{
    private readonly Random _random = new();
    public bool Ripe { get; set; }
    public event Action? Ripened;

    public void MaybeGrow()
    {
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            Ripened?.Invoke();
        }
    }
}

public class Notifier
{
    public Notifier(CharberryTree tree)
    {
        tree.Ripened += OnRipen;
    }

    private void OnRipen()
    {
        Console.WriteLine("Tree is ripe");
    }
}

public class Harvester
{
    private readonly CharberryTree _tree;

    public Harvester(CharberryTree tree)
    {
        tree.Ripened += OnHarvest;
        _tree = tree;
    }

    private void OnHarvest()
    {
        _tree.Ripe = false;
        Console.WriteLine("Tree has been harvested");
    }
}
