using System.ComponentModel.DataAnnotations;
using Flunt.Validations;
namespace TaskFlow.Domain.Commands.Contracts;

public interface ICommand : IValidatableObject
{
    bool Validate();
}
