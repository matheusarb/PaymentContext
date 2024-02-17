using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain;

public class PayPalPayment : Payment
{
    public PayPalPayment(
        Email email,
        string transactionCode,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        Document document,
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
        Email = email;
        TransactionCode = transactionCode;
    }

    public Email Email { get; private set; }
    public string TransactionCode { get; private set; }
}