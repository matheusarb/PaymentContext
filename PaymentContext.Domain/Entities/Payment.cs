namespace PaymentContext.Domain;

public abstract class Payment
{
    public string Number { get; private set; }
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Document { get; private set; }
    public string Owner { get; private set; }
    public string Address { get; private set; }
}

public class BoletoPayment : Payment
{
    public string BarCode { get; set; }
    public string Email { get; set; }
    public string BoletoNumber { get; set; }
}

public class CreditCardPayment : Payment
{
    public string CardHolderName { get; set; }
    public string CardNumber { get; set; }
    public string LastTransactionNumber { get; set; }
}

public class PaypalPayment : Payment
{
    public string Email { get; set; }
    public string TransactionCode { get; set; }
}