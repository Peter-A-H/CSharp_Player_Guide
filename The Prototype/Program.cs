int chosenNumber;
do
{
    Console.WriteLine("User 1, enter a number between 0 and 100");
    chosenNumber = Convert.ToInt32(Console.ReadLine());
}
while (chosenNumber < 0 || chosenNumber > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number");

int guess;
while (true)
{
    Console.WriteLine("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess < 0 || guess > 100)
    {
        continue;
    }

    if (guess > chosenNumber)
    {
        Console.WriteLine($"{guess} is too high.");
        continue;
    }

    if (guess < chosenNumber)
    {
        Console.WriteLine($"{guess} is too low.");
        continue;
    }

    Console.WriteLine("You guessed the number!");
    break;
}
