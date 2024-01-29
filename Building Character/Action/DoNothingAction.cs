namespace TheUncodedOne.Action;

public class DoNothingAction : IAction
{
    public void RunAction(Character character) => Console.WriteLine($"{character.Name} did NOTHING.");
}
