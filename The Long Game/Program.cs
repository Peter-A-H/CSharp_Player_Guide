Console.Write("Enter your name: ");
string? name = Console.ReadLine();

int score = 0;
string fileName = $"{name}.txt";

if (File.Exists(fileName))
{
    score = Convert.ToInt32(File.ReadAllText(fileName));
    Console.WriteLine($"Welcome back, {name}. Your score will resume at {score}.");
}

while (true)
{
    ConsoleKey key = Console.ReadKey().Key;
    if (key == ConsoleKey.Escape) break;
    score++;
    Console.WriteLine(score);
}

File.WriteAllText(fileName, score.ToString());
