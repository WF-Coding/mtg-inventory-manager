using MTG.InventoryManager.Domain.Authentication;
using MTG.InventoryManager.Domain.Cards.ValueObjects;

namespace MTG.InventoryManager.Domain.Decks;

public sealed class Deck
{
    public UserId UserId { get; }
    public DeckName Name { get; }
    public DeckDescription Description { get; }
    public IReadOnlyCollection<CardId> CardIds { get; }
}