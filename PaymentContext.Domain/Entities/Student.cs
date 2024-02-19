using System.Diagnostics.Contracts;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain;

public class Student : Entity
{
    private IList<Subscription> _subscriptions = new List<Subscription>();

    public Student(Name name, Document document, Email email, Address address)
    {
        Name = name;
        Document = document;
        Email = email;
        Address = address;
        
        AddNotifications(name, document, email);
    }

    public Name Name { get; set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }

    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    public void AddSubscription(Subscription subscription)
    {
        var hasSubscriptionActive = false;
        foreach(var subs in _subscriptions)
            if(subs.IsActive == true)
                hasSubscriptionActive = true;
        //
        
        //cancelar todas as assinaturas existentes e ativar a nova
        // foreach (var sub in _subscriptions)
        //     sub.Inactivate();

        _subscriptions.Add(subscription);
    }
}