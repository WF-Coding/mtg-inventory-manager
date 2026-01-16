using MTG.InventoryManager.Domain.Exceptions;

namespace MTG.InventoryManager.Domain.Cards.ValueObjects;

public sealed record CardId
{
    public static CardId CreateNew() => new(Guid.NewGuid());

    public static CardId FromExisting(Guid value)
    {
        if (value == Guid.Empty)
            throw new InvalidCardIdException($"Card ID cannot be an empty UUID: [{value:D}]");
        
        return new CardId(value);
    }
    
    private CardId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }
}