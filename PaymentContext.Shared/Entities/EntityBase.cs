using Flunt.Notifications;

namespace PaymentContext.Shared.Entities;

public class EntityBase : Notifiable
{
    public EntityBase()
    {
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; set; }
}