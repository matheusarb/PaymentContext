using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers;

public class SubscriptionHandler : Notifiable<Notification>, IHandler<CreateBoletoSubscriptionCommand>
{
    private readonly IStudentRepository _repository;
    private readonly IEmailService _emailService;

    public SubscriptionHandler(IStudentRepository repository, IEmailService email)
    {
        _repository = repository;
        _emailService = email;
    }

    public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
    {
        // Fail Fast Validate
        command.Validate();
        if (!command.IsValid)
            return new CommandResult(false, "não foi possível realizar a assinatura");

        // Verificar se o Documento já está cadastrado
        if (_repository.DocumentExists(command.Document))
            AddNotification("Document", "documento já está cadastrado");

        // Verificar se E-mail já está cadastrado
        if (_repository.EmailExists(command.Email))
            AddNotification("Email", "Este e-mail já existe");

        // Gerar os VOs
        var name = new Name(command.FirstName, command.LastName);
        var document = new Document(command.PaymentNumber, command.PayerDocumentType);
        var email = new Email(command.Email);
        var address = new Address(command.Street, command.Number, command.State, command.Country);
        string owner = "";

        // Gerar as Entidades
        var student = new Student(name, document, email, address);
        var subscription = new Subscription(DateTime.Now.AddMonths(1));
        var payment = new BoletoPayment(
            command.BarCode, email, command.BoletoNumber,
            command.PaidDate, command.ExpireDate,
            command.Total,
            command.TotalPaid, new Document(command.PayerDocument, command.PayerDocumentType),
            owner,
            address);

        // Adicionar Relacionamentos
        subscription.AddPayment(payment);
        student.AddSubscription(subscription);

        // Aplicar as validações
        AddNotifications(name, document, email, address, student);

        // Salvar as informações
        _repository.CreateSubscription(student);

        // Enviar e-mail de boas vindas
        _emailService.GreetingsMail(student.Name.FullName, student.Email.Address, "Welcome", "Sua assinatura foi criada");

        // Retornar info
        return new CommandResult(true, "Assinatura realizada com sucesso");
    }
}