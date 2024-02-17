namespace PaymentContext.Domain;

public class Subscription
{
    private IList<Payment> _payments = new List<Payment>();

    public Subscription(DateTime? expireDate)
    {
        CreateDate = DateTime.Now;
        LastUpdateDate = DateTime.Now;
        ExpireDate = expireDate;
        IsActive = true;
    }

    public DateTime CreateDate { get; private set; }
    public DateTime LastUpdateDate { get; private set; }
    public DateTime? ExpireDate { get; private set; }
    public bool IsActive { get; private set; }

    public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray(); } }

    public void AddPayment(Payment payment)
    {
        _payments.Add(payment);
    }

    public void Activate()
    {
        IsActive = true;
        LastUpdateDate = DateTime.Now;
    }
    
    public void Inactivate()
    {
        IsActive = false;
        LastUpdateDate = DateTime.Now;
    }
}