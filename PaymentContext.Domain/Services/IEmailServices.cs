namespace PaymentContext.Domain.Services;

public interface IEmailService
{
    public void GreetingsMail(string to, string email, string subject, string body);
    
}