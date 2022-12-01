using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class CredtCardPayment : Payment
{
    public CredtCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, 
                            DateTime paidDate, DateTime expireDate, decimal total,
                            decimal totalPaid, string owner, Document document, Address address, Email email)
                            : base(paidDate, expireDate, total,totalPaid, owner, document, address, email)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName { get; private set; } = string.Empty;
    public string CardNumber { get; private set; } = string.Empty;
    public string LastTransactionNumber { get; private set; } = string.Empty;
}
