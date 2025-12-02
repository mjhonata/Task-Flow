using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;
using TaskFlow.Domain.Commands.Contracts;

namespace TaskFlow.Domain.Commands;

public class CreateTodoCommand : Notifiable<Notification>, ICommand
{
    #region Propi
    public string Title { get; set; }
    public string Description { get; set; }
    public string User { get; set; }
    public DateTime Date { get; set; }
    #endregion
    #region Constructors
    public CreateTodoCommand(string title, string description, string user, DateTime date)
    {
        Title = title;
        Description = description;
        User = user;
        Date = date;
    }
    public CreateTodoCommand() { }
    #endregion
    public void Validate()
    {
        AddNotifications(new Contract<CreateTodoCommand>()
            .Requires()
            .IsNotNullOrEmpty(Title, "Title", "O título não pode ser vazio")
            .IsNotNullOrEmpty(User, "User", "O usuário não pode ser vazio")
            .IsGreaterThan(Date, DateTime.Now.AddDays(-1), "Date", "A data não pode ser menor que a data atual")
        );
    }
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        Validate();
        return null;
    }
}