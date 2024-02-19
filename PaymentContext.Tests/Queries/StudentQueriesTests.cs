using PaymentContext.Domain;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
public class StudentQueriesTests
{
    //Red, Green, Refactor
    private readonly IList<Student> _students;

    public StudentQueriesTests()
    {
        for(var i=0; i<=10;i++)
        {
            _students.Add(new Student(
                new Name("Aluno", i.ToString()),
                new Document("123445678", EDocumentType.CPF),
                new Email($"{i.ToString()}@email.com")
            ));
        }
    }

    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
        var exp = StudentQueries.GetStudentInfo("12345567891011");
        var studnt = _students.AsQueryable().Where(exp).FirstOrDefault();

        Assert.AreNotEqual(null, studnt);
    }

}

