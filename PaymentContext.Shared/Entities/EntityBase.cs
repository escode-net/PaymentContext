namespace PaymentContext.Shared.Entities;

public class EntityBase
{
    public EntityBase()
    {
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; set; }
}