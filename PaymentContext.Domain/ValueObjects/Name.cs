using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FirstName, 3, nameof(Name.FirstName), "Primeiro nome deve conter ao menos 3 caracteres!")
            .HasMinLen(LastName, 3, nameof(Name.LastName), "Sobrenome deve conter ao menos 3 caracteres!")
        );
    }

    public string FirstName { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
}