using TaskFlow.Domain.Entities;
using TaskFlow.Domain.Commands;
using System.Reflection;

namespace TaskFlow.Tests.Domain.Tests.CommandTests;

public class CreateTodoCommandTests
{
    #region Propriedades
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", "Matheus", DateTime.Now);
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo", "Descrição", "Matheus", DateTime.Now.AddDays(1));
    #endregion

    #region Métodos de Teste
    [Fact]
    public void Dado_Um_Comando_Invalido()
    {
        //Arrange é quando preparamos o teste
        //Act é quando executamos a ação que será testada
        _invalidCommand.Validate();
        //Assert é para verificar se o resultado está correto
        Assert.False(_invalidCommand.IsValid);
    }
    [Fact]
    public void Dado_Um_Comando_Valido()
    {
        //Arrange é quando preparamos o teste
        //Act é quando executamos a ação que será testada
        _validCommand.Validate();
        //Assert é para verificar se o resultado está correto
        Assert.True(_validCommand.IsValid);
    }
    #endregion
}