int manticoreHealth = 10;
int manticoreMaxHealth = 10;
int manticoreDistance;
int cityHealth = 15;
int cityMaxHealth = 15;
int round = 1;

void DisplayStatus()
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/{cityMaxHealth} Manticore: {manticoreHealth}/{manticoreMaxHealth}");
}

int CannonDamage()
{
    if (round % 3 == 0 && round % 5 == 0) return 10;
    else if (round % 5 == 0) return 3;
    else if (round % 3 == 0) return 3;
    else return 1;
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

void DisplayHitStatus()
{
    string hitType = CannonAccuracy();

    if (hitType == "DIRECT HIT!") Console.WriteLine($"That round was a {hitType}");
    else if (hitType == "OVERSHOT" || hitType == "FELL SHORT") Console.WriteLine($"That round {hitType} the target.");
}

int PromptCannonRange()
{
    int range;

    Console.Write("Enter desired cannon range: ");
    range = Convert.ToInt32(Console.ReadLine());

    return range;
}

string CannonAccuracy()
{
    int range = PromptCannonRange();

    if (range > manticoreDistance) return "OVERSHOT";
    else if (range < manticoreDistance) return "FELL SHORT";
    else return "DIRECT HIT!";
}

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
manticoreDistance = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");
Console.WriteLine("----------------------------------------------------------------------------");

while (cityHealth > 0 || manticoreHealth > 0)
{
    DisplayStatus();
    DisplayDamage();
    CannonAccuracy();
    DisplayHitStatus();
}