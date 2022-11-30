namespace PaymentContext.Domain.Entities;

public class Student
{
    public Student(string firstName, string lastName, string document, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;

        if (string.IsNullOrEmpty(firstName))
            throw new Exception("Nome inválido");
    }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    public List<Subscription> Subscriptions { get; set; } = new();
}