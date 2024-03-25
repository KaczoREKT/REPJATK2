namespace Solution_4.Exceptions;

public class NoCargoException : Exception
{
    public NoCargoException()
    {
    }

    public NoCargoException(string? message) : base(message)
    {
    }

    public NoCargoException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}