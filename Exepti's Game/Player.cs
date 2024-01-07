using CustomExceptions;

namespace Game
{
    public class Player(int playerType)
    {
        public int ChosenNumber { get; private set; }
        public int PlayerType { get; } = playerType;
        public static List<int> PreviousNumbers { get; private set; } = [];

        public void PickNumber()
        {
            Console.Write($"Player {PlayerType}, pick a number between 0-9: ");
            string? response = Console.ReadLine();
            if (response == null) return;
            int chosenNumber = 0;

            try
            {
                chosenNumber = Convert.ToInt32(response);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            if (chosenNumber < 0 || chosenNumber > 9)
            {
                throw new ValueOutOfRangeException("Please enter a number between 0-9.\n");
            }

            if (PreviousNumbers.Contains(chosenNumber))
            {
                throw new DuplicateValueException($"{response} has already been chosen before.");
            }

            ChosenNumber = chosenNumber;
            PreviousNumbers.Add(ChosenNumber);
        }
    }
}
