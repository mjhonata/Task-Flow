namespace TaskFlow.Domain.Commands.Contracts;

public interface ICommand
{
    bool Validate();
}
