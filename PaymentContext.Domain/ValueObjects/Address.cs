using PaymentContext.Shared.ValueObjects;
namespace PaymentContext.Domain.ValueObjects;

public class Address : ValueObject
{
    public Address(string street, string number, string city, string state)
    {
        Street = street;
        Number = number;
        City = city;
        State = state;
    }

    public string Street { get; private set; }
    public string Number { get; private set; }
    public string Neighborhood { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string ZipCode { get; private set; }
}