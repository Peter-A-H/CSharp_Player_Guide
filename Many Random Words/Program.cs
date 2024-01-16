using System.Diagnostics;

while (true)
{
    Console.Write("Enter a word to randomly recreate: ");
    string? choice = Console.ReadLine();
    string word = choice ?? "hello";

    ParallelWords(word);
}

async void ParallelWords(string word)
{
    Stopwatch watch = new();
    watch.Start();
    int result = await RandomlyRecreateAsync(word);
    Console.WriteLine($"\nNumber of attempts to randomly create '{word}': {result}");
    watch.Stop();
    Console.WriteLine($"This took {watch.ElapsedMilliseconds / 1000} seconds");
}

Task<int> RandomlyRecreateAsync(string word)
{
    return Task.Run(() => RandomlyRecreate(word));
}

int RandomlyRecreate(string word)
{
    Random random = new();
    int numAttempts = 0;
    int wordLength = word.Length;
    List<char> newWord = [];

    while (string.Concat(newWord) != word)
    {
        newWord.Clear();

        for (int i = 0; i < wordLength; i++)
        {
            char randomLetter = (char)('a' + random.Next(26));
            newWord.Add(randomLetter);
        }

        numAttempts++;
    }

    return numAttempts;
}