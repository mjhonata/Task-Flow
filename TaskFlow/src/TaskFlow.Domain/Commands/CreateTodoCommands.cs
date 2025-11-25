using System.ComponentModel.DataAnnotations;
using TaskFlow.Domain.Commands.Contracts;

namespace TaskFlow.Domain.Commands;

public class CreateTodoCommand : ICommand
{
    #region Propi
    public string Title { get; set; }
    public string User { get; set; }
    public DateTime Date { get; set; }
   #endregion
    #region Constructors
    public CreateTodoCommand(string title, string user, DateTime date)
    {
        Title = title;
        User = user;
        Date = date;
    }
    public CreateTodoCommand() {}
    #endregion
    public bool Validate()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        throw new NotImplementedException();
    }
}