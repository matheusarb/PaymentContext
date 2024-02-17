namespace PaymentContext.Domain;

public class Student
{
    public Student(string firstName, string lastName, string document, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }  
    public string Document { get; private set; }  
    public string Email { get; private set; } 
    public string Address { get; private set; }

    public List<Subscription> Subscriptions { get; set; }

}