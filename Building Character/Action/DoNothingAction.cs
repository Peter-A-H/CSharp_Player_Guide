using Building_Character.Characters;

namespace Building_Character.Action;

public class DoNothingAction : IAction
{
    public void RunAction(Character character) => Console.WriteLine($"{character.Name} did NOTHING.");
}
