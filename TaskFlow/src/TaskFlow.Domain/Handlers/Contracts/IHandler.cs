using TaskFlow.Domain.Commands.Contracts;

namespace TaskFlow.Domain.Handlers.Contracts;

public interface IHandler<T> where T : ICommand
{
    ICommandResult Handle(T command);
}