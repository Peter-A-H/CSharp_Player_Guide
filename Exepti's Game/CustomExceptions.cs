namespace CustomExceptions
{
    public class OatmealCookieException(string message) : Exception(message) { }
    public class ValueOutOfRangeException(string message) : Exception(message) { }
    public class DuplicateValueException(string message) : Exception(message) { }
}
