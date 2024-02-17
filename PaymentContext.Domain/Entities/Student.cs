namespace PaymentContext.Domain;

public class Student
{
    private IList<Subscription> _subscriptions = new List<Subscription>();

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

    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    public void AddSubscription(Subscription subscription)
    {
        //cancelar todas as assinaturas existentes e ativar a nova
        foreach (var sub in Subscriptions)
            sub.IsActive = false;

        _subscriptions.Add(subscription);
    }
}