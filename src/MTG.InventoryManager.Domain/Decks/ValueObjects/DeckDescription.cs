using MTG.InventoryManager.Domain.Exceptions;

namespace MTG.InventoryManager.Domain.Decks;

public sealed record DeckDescription
{
    public const int MaximumLength = 500;

    public static DeckDescription Empty => new DeckDescription(value: null);
    
    public static DeckDescription Create(string? description)
    {
        if (string.IsNullOrWhiteSpace(description))
            return Empty;

        if (description.Length > MaximumLength)
            throw new DeckDescriptionTooLongException();
        
        return new DeckDescription(description);
    }
    
    private DeckDescription(string? value)
    {
        Value = value;
    }
    
    public string? Value { get; }
}