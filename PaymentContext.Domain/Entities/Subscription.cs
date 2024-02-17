namespace PaymentContext.Domain;

public class Subscription
{
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public DateTime? ExpireDate { get; set; }
    public bool IsActive { get; set; }
    public List<Payment> Payments { get; set; }
}