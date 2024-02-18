using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Email : ValueObject
{
    public Email(string address)
    {
        Address = address;
    }
    
    [EmailAddress]
    public string Address { get; private set; }
}