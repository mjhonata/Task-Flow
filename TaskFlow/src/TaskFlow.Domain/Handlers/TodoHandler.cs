using Flunt.Notifications;
using TaskFlow.Domain.Commands;
using TaskFlow.Domain.Commands.Contracts;
using TaskFlow.Domain.Entities;
using TaskFlow.Domain.Handlers.Contracts;
using TaskFlow.Domain.Repositories;

namespace TaskFlow.Domain.Handlers;
//notifiable é para validar os dados, temos os metodos valid, notifications, etc
public class TodoHandler : Notifiable<Notification>, IHandler<CreateTodoCommand>
{
    private readonly ITodoRepository _repository;
    public TodoHandler(ITodoRepository repository)
    {
        _repository = repository;
    }
    public ICommandResult Handle(CreateTodoCommand command)
    {
        command.Validate();
        if (command.IsValid == false)
            return new GenericCommandResult(false, "Por favor, corrija os campos abaixo", command.Notifications);

        var todo = new TodoItem(command.Title, command.Description, false, command.Date, command.User);

        _repository.Create(todo.Title, todo.Description);
        return new GenericCommandResult(true, "Tarefa criada com sucesso", todo);
    }
}