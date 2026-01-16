using MTG.InventoryManager.Domain.Authentication;
using MTG.InventoryManager.Domain.Cards.ValueObjects;

namespace MTG.InventoryManager.Domain.Wishlist;

public sealed class Wishlist
{
    public UserId UserId { get; }
    public IReadOnlyCollection<CardId> CardIds { get; }
}