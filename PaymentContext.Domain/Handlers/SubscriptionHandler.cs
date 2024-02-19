using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers;

public class SubscriptionHandler : Notifiable<Notification>, IHandler<CreateBoletoSubscriptionCommand>
{
    private readonly IStudentRepository _repository;

    public SubscriptionHandler(IStudentRepository repository)
    {
        _repository = repository;
    }

    public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
    {
        // Fail Fast Validate
        command.Validate();
        if(!command.IsValid)
            return new CommandResult(false, "não foi possível realizar a assinatura");

        // Verificar se o Documento já está cadastrado
        if(_repository.DocumentExists(command.Document))
            AddNotification("Document", "documento já está cadastrado");

        // Verificar se E-mail já está cadastrado
        if(_repository.EmailExists(command.Email))
            AddNotification("Email", "Este e-mail já existe");

        // Gerar os VOs
        var name = new Name(command.FirstName, command.LastName);
        var document = new Document(command.PaymentNumber, command.PayerDocumentType);
        var email = new Email(command.Email);
        var address = new Address(command.Street, command.Number, command.State, command.Country);

        // Gerar as Entidades
        var student = new Student(name, document, email, address);

        // Aplicar as validações

        // Salvar as informações

        // Enviar e-mail de boas vindas

        return new CommandResult(true, "Assinatura realizada com sucesso");
    }
}