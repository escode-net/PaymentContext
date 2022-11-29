namespace PaymentContext.Domain.Entities;

public class CredtCardPayment : Payment
{
    public string CardHolderName { get; set; } = string.Empty;
    public string CardNumber { get; set; } = string.Empty;
    public string LastTransactionNumber { get; set; } = string.Empty;
}
