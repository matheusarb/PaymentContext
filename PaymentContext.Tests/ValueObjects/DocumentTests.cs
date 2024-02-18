using PaymentContext.Domain;
using PaymentContext.Domain.Enums;
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
        var doc = new Document("123", EDocumentType.CNPJ);
        Assert.IsFalse(doc.Validate());
    }
    
    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
        var doc = new Document("75619017000120", EDocumentType.CNPJ);
        Assert.IsTrue(doc.Validate());
    }
    
    //CPF Tests
    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("123", EDocumentType.CPF);
        Assert.IsFalse(doc.Validate());
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCPFIsValid()
    {
        var doc = new Document("85765843522", EDocumentType.CPF);
        Assert.IsTrue(doc.Validate());
    }
    

}