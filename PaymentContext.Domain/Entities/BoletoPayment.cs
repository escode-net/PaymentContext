namespace PaymentContext.Domain.Entities;

public class BoletoPayment : Payment
{
    public string BarCode { get; set; } = string.Empty;
    public string BoletoNumber { get; set; } = string.Empty;
}
