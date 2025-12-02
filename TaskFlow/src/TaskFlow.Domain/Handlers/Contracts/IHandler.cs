using TaskFlow.Domain.Commands.Contracts;

namespace TaskFlow.Domain.Handlers.Contracts;
//where dois pontos é para restringir o tipo generico T, desde que t seja um comando
public interface IHandler<T> where T : ICommand
{
    ICommandResult Handle(T command);
}