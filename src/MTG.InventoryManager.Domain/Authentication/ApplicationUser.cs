namespace MTG.InventoryManager.Domain.Authentication;

public sealed class ApplicationUser
{

    #region Properties
    
    public UserId Id { get; }
    
    #endregion
}

public sealed record UserId
{
    private UserId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }
}