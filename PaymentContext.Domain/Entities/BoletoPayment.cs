using System.Reflection.Metadata;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain;

public class BoletoPayment : Payment
{
    public BoletoPayment(
        string barCode,
        Email email,
        string boletoNumber,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        ValueObjects.Document document,
        string owner,
        Address address) : base(
             paidDate,
             expireDate,
             total,
             totalPaid,
             document,
             owner,
             address)
    {
        BarCode = barCode;
        Email = email;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; }
    public Email Email { get; private set; }
    public string BoletoNumber { get; private set; }
}