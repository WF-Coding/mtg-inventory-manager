using MTG.InventoryManager.Domain.Decks;

namespace MTG.InventoryManager.Domain.Exceptions;

public sealed class DeckDescriptionTooLongException()
    : DomainException($"Deck description exceeds the character limit ({DeckDescription.MaximumLength} characters).");