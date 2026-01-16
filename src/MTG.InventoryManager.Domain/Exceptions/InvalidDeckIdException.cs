namespace MTG.InventoryManager.Domain.Exceptions;

public class InvalidDeckIdException : DomainException
{
    public InvalidDeckIdException()
    {
    }

    public InvalidDeckIdException(string message)
        : base(message)
    {
    }

    public InvalidDeckIdException(string message, Exception inner)
        : base(message, inner)
    {
    }
}