using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string FullName { get { return $"{FirstName} {LastName}"; } }
}