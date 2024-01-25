UncodedOneGame game = new();
game.Run();

public class UncodedOneGame
{
    public void Run()
    {
        Party heroes = new([new TrueProgrammer()]);
        Party monsters = new([new Skeleton()]);
        Battle battle = new(heroes, monsters);
        Skeleton characterPlayingFirst = (Skeleton)monsters.Characters.First();

        battle.Start(characterPlayingFirst);
    }
}

public class Battle(Party heroes, Party monsters)
{
    public Party Heroes = heroes;
    public Party Monsters = monsters;

    public void Start(Skeleton characterPlayingFirst)
    {
        while (true)
        {
            Console.WriteLine($"It is {characterPlayingFirst.Name}'s turn...");
            Thread.Sleep(5000);
            Console.WriteLine();
        }
    }
}

public interface IAttackAction
{
    public byte Attack();
}

public class Party(List<Character> characters)
{
    public List<Character> Characters { get; private set; } = characters;
}

public class Character
{
    public sbyte HP { get; private set; } = 100;

    public void DoNothing()
    {
        return;
    }
}

public class Hero : Character
{

}

public class TrueProgrammer : Hero, IAttackAction
{
    public byte Attack()
    {
        byte damageAmount = 1;
        return damageAmount;
    }
}

public class Monster : Character
{

}

public class Skeleton : Monster, IAttackAction
{
    public string Name { get; private set; } = "SKELETON";

    public byte Attack()
    {
        Random random = new();
        byte damageAmount = (byte)random.Next(0, 2);
        return damageAmount;
    }
}

public class UncodedOne : Monster
{

}
