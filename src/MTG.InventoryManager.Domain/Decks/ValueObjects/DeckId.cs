using MTG.InventoryManager.Domain.Exceptions;

namespace MTG.InventoryManager.Domain.Decks;

public sealed record DeckId
{
    public static DeckId CreateNew() => new(Guid.NewGuid());

    public static DeckId FromExisting(Guid value)
    {
        if (value == Guid.Empty)
            throw new InvalidDeckIdException($"Deck ID cannot be an empty UUID: [{value:D}]");
        
        return new DeckId(value);
    }
    
    private DeckId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }
}