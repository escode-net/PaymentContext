using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public class Student : EntityBase
{
    private IList<Subscription> _subscripotions;

    public Student(Name name, Document document, Email email, Address address)
    {
        Name = name;
        Document = document;
        Email = email;
        Address = address;
        _subscripotions = new List<Subscription>();

        AddNotifications(name, document, email, address);
    }

    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }

    public IReadOnlyCollection<Subscription> Subscriptions => _subscripotions.ToArray();

    public void AddSubscription(Subscription subscription)
    {
        var hasSubscriptionActive = false;

        foreach (var sub in _subscripotions)
        {
            if (sub.Active)
                hasSubscriptionActive = true;
        }

        if (!hasSubscriptionActive)
            _subscripotions.Add(subscription);

        if (hasSubscriptionActive)
            AddNotification(nameof(Student.Subscriptions), "Você já tem uma assiantura ativa!");
    }
}