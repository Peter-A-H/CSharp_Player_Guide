public class UncodedOneGame
{

}

public interface IAttackAction
{
    public byte Attack();
}

public class Party
{

}

public class Character : Party
{
    public byte HP { get; set; }

    public void DoNothing()
    {
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