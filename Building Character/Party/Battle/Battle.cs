using Building_Character.Party;
using Building_Character.Party.Characters.Enemies;

public class Battle(Party heroes, Party monsters)
{
    public Party Heroes = heroes;
    public Party Monsters = monsters;

    public void Start(Skeleton enemy)
    {
        while (true)
        {
            Console.WriteLine($"It is {enemy.Name}'s turn...");
            Console.WriteLine($"{enemy.Name} did {enemy.DoNothing()}.");
            Console.WriteLine();
            Thread.Sleep(5000);
        }
    }
}