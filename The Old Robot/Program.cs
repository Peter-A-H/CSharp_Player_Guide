﻿Robot robot = new();

for (int index = 0; index < robot.Commands.Length; index++)
{
    string? input = Console.ReadLine();
    RobotCommand newCommand = input switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "east" => new EastCommand(),
        "west" => new WestCommand(),
        _ => new OffCommand(),
    };
    robot.Commands[index] = newCommand;
}

Console.WriteLine();

robot.Run();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];

    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1;
        }
        else
        {
            Console.WriteLine("Robot is not powered on.");
        }
    }
}

public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += 1;
        }
        else
        {
            Console.WriteLine("Robot is not powered on.");
        }
    }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y -= 1;
        }
        else
        {
            Console.WriteLine("Robot is not powered on.");
        }
    }
}

public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X -= 1;
        }
        else
        {
            Console.WriteLine("Robot is not powered on.");
        }
    }
}