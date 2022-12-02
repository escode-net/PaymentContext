using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Document : ValueObject
{
    public Document(string number, EDocumentType type)
    {
        Number = number;
        Type = type;

        AddNotifications(new Contract()
            .Requires()
            .IsTrue(Validate(), nameof(Document.Number), "Documento inválido!")
        );
    }

    public string Number { get; private set; } = string.Empty;
    public EDocumentType Type { get; private set; }

    private bool Validate()
    {
        if (Type == EDocumentType.CNPJ && Number.Length == 14)
            return true;

        if (Type == EDocumentType.CNPJ && Number.Length == 14)
            return true;

        return false;
    }

}