using TaskFlow.Domain.Entities;
using TaskFlow.Domain.Commands;
using System.Reflection;

namespace TaskFlow.Tests.Domain.Tests;

public class CreateTodoCommandTests
{
    private readonly TodoItem _todo;
    public CreateTodoCommandTests()
    {
        _todo = new TodoItem("Titulo de Teste", "Descrição de Teste", DateTime.Now, "usuario-teste");
    }
    [Fact]
    public void Dado_Um_Comando_Invalido()
    {
        //Arrange
        var command = new CreateTodoCommand("", "", "Matheus", DateTime.Now);
        //Act é quando executamos a ação que será testada
        command.Validate();
        //Assert é para verificar se o resultado está correto
        Assert.False(command.IsValid);
    }
    [Fact]
    public void Dado_Um_Comando_Valido()
    {
        //Arrange é quando preparamos o teste
        var command = new CreateTodoCommand("Titulo", "Descrição", "Matheus", DateTime.Now.AddDays(1));
        //Act é quando executamos a ação que será testada
        command.Validate();
        //Assert é para verificar se o resultado está correto
        Assert.True(command.IsValid);
    }
}