using PaymentContext.Domain;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    private readonly Student _student;
    private readonly Subscription _subscription;

    public StudentTests()
    {
        var name = new Name("Bruce", "Wayne");
        var document = new Document("1234567876", EDocumentType.CPF);
        var email = new Email("bruce@email.com");
        var address = new Address("StreetName", "999", "TX", "USA");
        _student = new Student(name, document, email);
        
        var payment = new PayPalPayment(new Email("mat@email.com"), "12345678", DateTime.Now, DateTime.Now, 100M, 100M, document, "batman", address);
        var subs = new Subscription(null);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenHadActiveSubscription()
    {

        _student.AddSubscription(_subscription);

    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenHadNoActiveSubscription()
    {
        Assert.Fail();
        
    }
}

