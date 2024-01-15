SharedData sharedData = new();
Thread thread = new(sharedData.Increment);
thread.Start();

sharedData.Increment();

thread.Join();

Console.WriteLine(sharedData.Number);

class SharedData
{
    private readonly object _numberLock = new();

    private int _number;

    public int Number
    {
        get
        {
            lock (_numberLock)
            {
                return _number;
            }
        }
    }

    public void Increment()
    {
        lock (_numberLock)
        {
            _number++;
        }
    }
}