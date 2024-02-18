using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain;

public class Student : Entity
{
    private IList<Subscription> _subscriptions = new List<Subscription>();

    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        
        AddNotifications(name, document, email);
    }

    public Name Name { get; set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }

    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    public void AddSubscription(Subscription subscription)
    {
        //cancelar todas as assinaturas existentes e ativar a nova
        foreach (var sub in Subscriptions)
            sub.Inactivate();

        _subscriptions.Add(subscription);
    }
}