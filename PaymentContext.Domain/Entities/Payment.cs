namespace PaymentContext.Domain;

public abstract class Payment
{
    protected Payment(
        DateTime paidDate, 
        DateTime expireDate, 
        decimal total, 
        decimal totalPaid, 
        string document, 
        string owner, 
        string address)
    {
        Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Document = document;
        Owner = owner;
        Address = address;
    }

    public string Number { get; private set; }
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Document { get; private set; }
    public string Owner { get; private set; }
    public string Address { get; private set; }
}