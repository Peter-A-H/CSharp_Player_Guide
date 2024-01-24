UncodedOneGame game = new();
game.Run();

public class UncodedOneGame
{
    public void Run()
    {
        Party heroes = new();
        Party monsters = new();
    }
}

public class Battle
{

}

public interface IAttackAction
{
    public byte Attack();
}

public class Party
{
    public List<Character> Characters { get; private set; } = [];
}

public class Character : Party
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