using System;
using TaskFlow.Domain.Commands;
using TaskFlow.Domain.Handlers;
namespace TaskFlow.Tests.Domain.Tests.HandlerTests;

public class CreateTodoHandlerTestes
{
    #region Properties
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand
    {
        Title = "",
        Description = "Descrição de teste",
        User = "",
        Date = DateTime.Now
    };
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand
    {
        Title = "Título de teste",
        Description = "Descrição de teste",
        User = "Usuário de teste",
        Date = DateTime.Now.AddDays(1)
    };
    private readonly TodoHandler _handler = new TodoHandler(new Repositories.FakeTodoRepository());
    private GenericCommandResult _result = new GenericCommandResult();
    #endregion
    [Fact]
    public void Dado_um_comando_invalido_deve_interromper_a_execucao()
    {
        _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
        Assert.Equal(_result.Success, false);
    }
    [Fact]
    public void Dado_um_comando_valido_deve_criar_a_tarefa()
    {
        _result = (GenericCommandResult)_handler.Handle(_validCommand);
        Assert.Equal(_result.Success, true);
    }
}