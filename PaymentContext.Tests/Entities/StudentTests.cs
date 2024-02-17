using PaymentContext.Domain;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var subscription = new Subscription(null);
        var student = new Student(
            new Name("Matheus", "Ribeiro"),
            new Document("1234567876",
            EDocumentType.CPF),
            new Email("matheus@email.com"));

    }
}

