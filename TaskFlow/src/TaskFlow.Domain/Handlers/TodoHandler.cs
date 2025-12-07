using Flunt.Notifications;
using TaskFlow.Domain.Commands;
using TaskFlow.Domain.Commands.Contracts;
using TaskFlow.Domain.Entities;
using TaskFlow.Domain.Handlers.Contracts;
using TaskFlow.Domain.Repositories;

namespace TaskFlow.Domain.Handlers;
//notifiable é para validar os dados, temos os metodos valid, notifications, etc
public class TodoHandler : Notifiable<Notification>, IHandler<CreateTodoCommand>, IHandler<UpdateTodoCommand>, IHandler<MarkTodoAsDoneCommand>, IHandler<MarkTodoAsUndoneCommand>
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

        var todo = new TodoItem(command.Title, command.Description, command.Date, command.User);

        _repository.Create(todo);
        return new GenericCommandResult(true, "Tarefa criada com sucesso", todo);
    }

    public ICommandResult Handle(UpdateTodoCommand command)
    {
        //validar os dados
        command.Validate();
        if (command.IsValid == false)
            return new GenericCommandResult(false, "Por favor, corrija os campos abaixo", command.Notifications);
        //recuperar o todo do banco
        var todo = _repository.GetById(command.Id, command.User);

        //alterar o todo
        todo.UpdateTitle(command.Title);
        todo.UpdateDescription(command.Description);

        //salvar o todo
        _repository.Update(todo);

        //retornar o resultado
        return new GenericCommandResult(true, "Tarefa atualizada com sucesso", todo);
    }

    public ICommandResult Handle(MarkTodoAsDoneCommand command)
    {
        //validar os dados
        command.Validate();
        if (command.IsValid == false)
            return new GenericCommandResult(false, "Por favor, corrija os campos abaixo", command.Notifications);

        //recuperar o todo do banco
        var todo = _repository.GetById(command.Id, command.User);

        //marcar como feito
        todo.MarkAsDone();

        //salvar o todo
        _repository.Update(todo);

        //retornar o resultado
        return new GenericCommandResult(true, "Tarefa marcada como feita com sucesso", todo);
    }

    public ICommandResult Handle(MarkTodoAsUndoneCommand command)
    {
        //validar os dados
        command.Validate();
        if (command.IsValid == false)
            return new GenericCommandResult(false, "Por favor, corrija os campos abaixo", command.Notifications);

        //recuperar o todo do banco
        var todo = _repository.GetById(command.Id, command.User);

        //marcar como não feito
        todo.MarkAsUndone();

        //salvar o todo
        _repository.Update(todo);

        //retornar o resultado
        return new GenericCommandResult(true, "Tarefa marcada como não feita com sucesso", todo);
    }
}