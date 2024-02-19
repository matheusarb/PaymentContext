using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers;

public class SubscriptionHandler : 
    Notifiable<Notification>,
    IHandler<CreateBoletoSubscriptionCommand>
{
    public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
    {
        // Fail Fast Validate
        command.Validate();
        if(!command.IsValid)
            return new CommandResult(false, "não foi possível realizar a assinatura");

        // Verificar se o Documento já está cadastrado


        // Verificar se E-mail já está cadastrado

        // Gerar os VOs

        // Gerar as Entidades

        // Aplicar as validações

        // Salvar as informações

        // Enviar e-mail de boas vindas

        return new CommandResult(true, "Assinatura realizada com sucesso");
    }
}