var validator = new PasswordValidator("PeterAH1234!");
Console.WriteLine(validator.Validate());

public class PasswordValidator(string password)
{
    public string Password { get; private set; } = password;

    public bool Validate()
    {
        bool hasLowerCase = false;
        bool hasUpperCase = false;
        bool hasDigit = false;

        if (Password == null || Password.Length < 6 || Password.Length > 13)
        {
            return false;
        }

        foreach (char letter in Password)
        {
            if (letter == 'T' || letter == '&')
            {
                return false;
            }
        }

        foreach (char letter in Password)
        {
            if (char.IsUpper(letter)) hasUpperCase = true;
            if (char.IsLower(letter)) hasLowerCase = true;
            if (char.IsDigit(letter)) hasDigit = true;
        }

        return hasUpperCase && hasLowerCase && hasDigit;
    }
}