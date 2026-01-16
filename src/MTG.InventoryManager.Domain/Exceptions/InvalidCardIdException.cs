namespace MTG.InventoryManager.Domain.Exceptions;

public class InvalidCardIdException : DomainException
{
    public InvalidCardIdException()
    {
    }

    public InvalidCardIdException(string message)
        : base(message)
    {
    }

    public InvalidCardIdException(string message, Exception inner)
        : base(message, inner)
    {
    }
}