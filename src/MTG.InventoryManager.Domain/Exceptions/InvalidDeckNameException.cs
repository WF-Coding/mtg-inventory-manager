namespace MTG.InventoryManager.Domain.Exceptions;

public sealed class InvalidDeckNameException : DomainException
{
    public InvalidDeckNameException()
    {
    }

    public InvalidDeckNameException(string message)
        : base(message)
    {
    }

    public InvalidDeckNameException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}