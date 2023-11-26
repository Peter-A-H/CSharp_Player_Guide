Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy to: ");

Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.White;
Console.Beep(440, 500);

Console.WriteLine($"({row}, {--column})");
Console.WriteLine($"({--row}, {++column})");
Console.WriteLine($"({++row}, {++column})");
Console.WriteLine($"({++row}, {--column})");

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
