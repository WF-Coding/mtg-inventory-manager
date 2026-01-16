using MTG.InventoryManager.Domain.Exceptions;

namespace MTG.InventoryManager.Domain.Decks;

public sealed record DeckName
{
    public const int MaxLength = 150;
    
    public static DeckName Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new InvalidDeckNameException("Deck name cannot be null, empty string, or a string containing only whitespace characters.");
        
        if (name.Length > MaxLength)
            throw new DeckNameTooLongException(name);

        return new DeckName(name);
    }
    
    private DeckName(string value)
    {
        Value = value;
    }
    
    public string Value { get; }
}