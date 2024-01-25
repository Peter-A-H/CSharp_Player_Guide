using Building_Character.Party;
using Building_Character.Party.Characters.Enemies;
using Building_Character.Party.Characters.Heroes;

public class Battle(Party heroes, Party monsters)
{
    public Party Heroes { get; private set; } = heroes;
    public Party Monsters { get; private set; } = monsters;
    public dynamic? CurrentCharacter { get; private set; }
    readonly Skeleton _enemy = (Skeleton)monsters.Characters.First();
    readonly TrueProgrammer _hero = (TrueProgrammer)heroes.Characters.First();

    public void Start()
    {
        CurrentCharacter = _hero;
        while (true)
        {
            Console.WriteLine($"It is {CurrentCharacter.Name}'s turn...");
            Console.WriteLine($"{CurrentCharacter.Name} did {CurrentCharacter.DoNothing()}.");
            Console.WriteLine();
            Thread.Sleep(5000);
            CurrentCharacter = (CurrentCharacter == _hero) ? _enemy : _hero;
        }
    }
}