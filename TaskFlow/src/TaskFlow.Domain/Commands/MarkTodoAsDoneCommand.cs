using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using TaskFlow.Domain.Commands.Contracts;

namespace TaskFlow.Domain.Commands;

public class MarkTodoAsDoneCommand : Notifiable<Notification>, ICommand
{
    public void Validate()
    {
        throw new Exception("");
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }
}