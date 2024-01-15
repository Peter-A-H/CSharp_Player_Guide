RecentNumbers recentNumbers = new();
Thread thread = new(recentNumbers.Run);
thread.Start();

while (true)
{
    recentNumbers.Run();
    Console.WriteLine(string.Format("Here's the list from main: ({0}).", string.Join(", ", recentNumbers.NumbersList)));
}

public class RecentNumbers
{
    private readonly object _numberLock = new();
    private List<int> _recentNumbers = [];

    public List<int> NumbersList
    {
        get
        {
            lock (_numberLock)
            {
                return _recentNumbers;
            }
        }
    }

    public void Run()
    {
        lock (_numberLock)
        {
            while (true)
            {
                Thread.Sleep(1000);
                Random random = new();
                int num = random.Next(10);

                if (_recentNumbers.Count == 2)
                {
                    _recentNumbers[0] = _recentNumbers[1];
                    _recentNumbers.Remove(_recentNumbers[1]);
                    _recentNumbers.Add(num);
                }
                else
                {
                    _recentNumbers.Add(num);
                }

                Console.WriteLine(string.Format("Here's the list from thread: ({0}).", string.Join(", ", _recentNumbers)));
            }
        }
    }
}