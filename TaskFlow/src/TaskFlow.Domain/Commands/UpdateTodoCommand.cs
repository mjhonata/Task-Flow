using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;
using TaskFlow.Domain.Commands.Contracts;

namespace TaskFlow.Domain.Commands;

public class UpdateTodoCommand : Notifiable<Notification>, ICommand
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string User { get; set; }


    public UpdateTodoCommand(Guid id, string title, string? description, string user)
    {
        Id = id;
        Title = title;
        Description = description;
        User = user;
    }

    public UpdateTodoCommand() { }

    public event EventHandler? CanExecuteChanged;

    public void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(Id, "Id", "Id do Todo não pode ser nulo")
            .IsGreaterThan(Id.ToString().Length, 0, "Id", "Id do Todo inválido")
            .IsNotNull(Title, "Title", "Título não pode ser nulo")
            .IsGreaterThan(Title?.Length ?? 0, 3, "Title", "Título deve ter mais de 3 caracteres")
            .IsNotNull(User, "User", "Usuário não pode ser nulo")
            .IsGreaterThan(User?.Length ?? 0, 0, "User", "Usuário inválido")
        );
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }
}