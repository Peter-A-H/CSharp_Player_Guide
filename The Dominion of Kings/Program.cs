int totalScore = 0;

Console.WriteLine("How many provinces do you have? ");
int provinces = Convert.ToInt32(Console.ReadLine());
totalScore += provinces;

Console.WriteLine("How many duchies do you have? ");
int duchies = Convert.ToInt32(Console.ReadLine());
totalScore += duchies * 3;

Console.WriteLine("How many estates do you have? ");
int estates = Convert.ToInt32(Console.ReadLine());
totalScore += estates * 6;

Console.WriteLine("Your total score is: " + totalScore);
