using PaymentContext.Domain;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
public class DocumentTests
{
    //Red, Green, Refactor

    // CNPJ Tests
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
        Assert.Fail();
    }
    
    //CPF Tests
    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
        Assert.Fail();
    }
    

}