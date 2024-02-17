using PaymentContext.Domain;
namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var subscription = new Subscription(null);
        var student = new Student("Matheus", "Ribeiro", "1234567890", "matheus@email.com");

    }
}

