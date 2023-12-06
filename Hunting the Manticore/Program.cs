int manticoreHealth = 10;
int manticoreMaxHealth = 10;
int manticoreDistance;
int cityHealth = 15;
int cityMaxHealth = 15;
int round = 1;

do
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticore? (0-100) ");
    manticoreDistance = Convert.ToInt32(Console.ReadLine());

    if (manticoreDistance < 0 || manticoreDistance > 100)
    {
        Console.Clear();
        Console.WriteLine("Please enter a number between 0 and 100.");
    }
} while (manticoreDistance < 0 || manticoreDistance > 100);

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

while (cityHealth > 0 && manticoreHealth > 0)
{
    Console.WriteLine("----------------------------------------------------------------------------");
    DisplayStatus();
    DisplayDamage();

    int range = PromptCannonRange();
    string accuracy = CannonAccuracy(range);

    DisplayHitStatus(accuracy);

    if (accuracy == "DIRECT HIT!") manticoreHealth -= CannonDamage();
    ++round;
    --cityHealth;

    CheckForWinner();
}

void DisplayStatus()
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/{cityMaxHealth} Manticore: {manticoreHealth}/{manticoreMaxHealth}");
}

int CannonDamage()
{
    if (round % 3 == 0 && round % 5 == 0) return 10;
    else if (round % 5 == 0) return 3;
    else if (round % 3 == 0) return 3;
    return 1;
}

string CannonDamageType()
{
    if (round % 3 == 0 && round % 5 == 0) return "fire-electric";
    else if (round % 5 == 0) return "electric";
    else if (round % 3 == 0) return "fire";
    return "";
}

void DisplayDamage()
{
    if (CannonDamageType() == "") Console.WriteLine($"The cannon is expected to deal {CannonDamage()} damage this round.");
    else Console.WriteLine($"The cannon is expected to deal {CannonDamage()} {CannonDamageType()} damage this round.");
}

void DisplayHitStatus(string hitType)
{
    if (hitType == "DIRECT HIT!") Console.WriteLine($"That round was a {hitType}");
    else if (hitType == "FELL SHORT") Console.WriteLine($"That round {hitType} of the target.");
    else Console.WriteLine($"That round {hitType} the target.");
}

int PromptCannonRange()
{
    int range;

    Console.Write("Enter desired cannon range: ");
    range = Convert.ToInt32(Console.ReadLine());

    return range;
}

string CannonAccuracy(int range)
{
    if (range > manticoreDistance) return "OVERSHOT";
    else if (range < manticoreDistance) return "FELL SHORT";
    return "DIRECT HIT!";
}

void CheckForWinner()
{
    if (cityHealth <= 0) Console.WriteLine("The city has been destroyed!");
    else if (manticoreHealth <= 0) Console.WriteLine("The manticore has been destroyed!");
}
