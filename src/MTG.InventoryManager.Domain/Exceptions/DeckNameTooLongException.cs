namespace MTG.InventoryManager.Domain.Exceptions;

public sealed class DeckNameTooLongException(string name)
    : DomainException($"Deck name '{name}' exceeds the character limit.");