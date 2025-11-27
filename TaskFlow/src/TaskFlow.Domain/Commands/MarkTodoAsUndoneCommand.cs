using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;
using TaskFlow.Domain.Commands.Contracts;
//essa classe representa o comando para marcar uma tarefa como não concluída (undone), é o mesmo código do MarkTodoAsDoneCommand, porém esse sistema pode escalar eai é interessando duas classes para manter consistência. 
namespace TaskFlow.Domain.Commands;

public class MarkTodoAsUndoneCommand : Notifiable<Notification>, ICommand
{
    public Guid Id { get; set; }
    public string User { get; set; }
    public MarkTodoAsUndoneCommand(Guid id, string user)
    {
        Id = id;
        User = user;
    }
    public MarkTodoAsUndoneCommand(){}
    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(Id, "Id", "Id do Todo não pode ser nulo")
            .IsGreaterThan(Id.ToString().Length, 0, "Id", "Id do Todo inválido")
            .IsNotNull(User, "User", "Usuário não pode ser nulo")
            .IsGreaterThan(User?.Length ?? 0, 0, "User", "Usuário inválido")
        );
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }
}