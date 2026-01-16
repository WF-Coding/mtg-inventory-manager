using MTG.InventoryManager.Domain.Authentication;
using MTG.InventoryManager.Domain.Decks;

namespace MTG.InventoryManager.Domain.Inventory;

public sealed class Inventory
{
    public UserId UserId { get; }
    public IReadOnlyCollection<DeckId> DeckIds { get; }
}