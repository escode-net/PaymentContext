using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public abstract class Payment : EntityBase
{
    protected Payment(DateTime paidDate, DateTime expireDate, decimal total,
                      decimal totalPaid, string owner, Document document, Address address, Email email)
    {
        Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Owner = owner;
        Document = document;
        Address = address;
        Email = email;

        AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(0, Total, nameof(Payment.TotalPaid), "O total não pode ser zero")
            .IsGreaterOrEqualsThan(Total, TotalPaid, nameof(Payment.TotalPaid), "O valor pago não pode ser menor que o valor calculado")
        );
    }

    public string Number { get; private set; } = string.Empty;
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Owner { get; private set; } = string.Empty;
    public Document Document { get; private set; }
    public Address Address { get; private set; }
    public Email Email { get; private set; }
}