Console.WriteLine("Enter a number of eggs: ");
int sisters = Convert.ToInt32(Console.ReadLine()) / 4;
int duckbear = sisters % 4;
Console.WriteLine("Each of the four sisters get " + sisters + " eggs");
Console.WriteLine("The duckbear gets the remaining " + duckbear + " eggs");
