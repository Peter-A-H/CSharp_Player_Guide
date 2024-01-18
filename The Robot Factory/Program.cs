using System.Dynamic;

int nextRobotID = 1;

while (true)
{
    dynamic robot = new ExpandoObject();
    robot.ID = nextRobotID;
    Console.WriteLine($"You are producing robot {robot.ID}");
    Console.Write("Do you want to name this robot? ");
    string? renameRobotChoice = Console.ReadLine();

    if (renameRobotChoice == "yes")
    {
        Console.Write("What is its name? ");
        string? robotName = Console.ReadLine();
        robot.Name = robotName;
    }

    Console.Write("Does this robot have a specific size? ");
    string? robotSizeChoice = Console.ReadLine();

    if (robotSizeChoice == "yes")
    {
        Console.Write("What is its height? ");
        int robotHeight = Convert.ToInt32(Console.ReadLine());
        robot.Height = robotHeight;

        Console.Write("What is its width? ");
        int robotWidth = Convert.ToInt32(Console.ReadLine());
        robot.Width = robotWidth;
    }

    Console.Write("Does this robot need to be a specific color? ");
    string? robotColorChoice = Console.ReadLine();

    if (robotColorChoice == "yes")
    {
        Console.Write("What color? ");
        string? robotColor = Console.ReadLine();
        robot.Color = robotColor;
    }

    foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)robot)
    {
        Console.WriteLine($"{property.Key}: {property.Value}");
    }

    nextRobotID++;
}