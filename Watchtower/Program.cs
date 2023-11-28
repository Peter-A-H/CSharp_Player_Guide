Console.WriteLine("Enter a X value: ");
int xValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a Y value: ");
int yValue = Convert.ToInt32(Console.ReadLine());

if (xValue == 0 && yValue == 0)
{
    Console.WriteLine("The enemy is here!");
}
else if (xValue < 0 && yValue > 0)
{
    Console.WriteLine("The enemy is north-west!");
}
else if (xValue == 0 && yValue > 0)
{
    Console.WriteLine("The enemy is in the north!");
}
else if (xValue > 0 && yValue > 0)
{
    Console.WriteLine("The enemy is in the north-east!");
}
else if (xValue > 0 && yValue == 0)
{
    Console.WriteLine("The enemy is in the west!");
}
else if (xValue > 0 && yValue < 0)
{
    Console.WriteLine("The enemy is in the south-east!");
}
else if (xValue == 0 & yValue < 0)
{
    Console.WriteLine("The enemy is in the south!");
}
else if (xValue < 0 && yValue < 0)
{
    Console.WriteLine("The enemy is in the south-west!");
}
else if (xValue < 0 && yValue == 0)
{
    Console.WriteLine("The enemy is in the west!");
}