namespace PaymentContext.Domain;

public class PayPalPayment : Payment
{
    public PayPalPayment(
        string email,
        string transactionCode,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string document,
        string owner,
        string address) : base(
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

    public string Email { get; private set; }
    public string TransactionCode { get; private set; }
}