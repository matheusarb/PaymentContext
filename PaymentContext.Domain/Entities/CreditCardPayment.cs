using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain;

public class CreditCardPayment : Payment
{
    public CreditCardPayment(
         string cardHolderName,
         string cardNumber,
         string lastTransactionNumber,
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
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }

    public string CardHolderName { get; private set; }
    public string CardNumber { get; private set; }
    public string LastTransactionNumber { get; private set; }
}