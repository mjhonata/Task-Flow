namespace TaskFlow.Tests.Domain.Tests.HandlerTests;

public class CreateTodoHandlerTests

{
    #region Propriedades
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", "Matheus", DateTime.Now);
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo", "Descrição", "Matheus", DateTime.Now.AddDays(1));
    #endregion
    [Fact]
    public void Dado_Um_Comando_Invalido_deve_interromper_a_execucao()
    {
        //Arrange é quando preparamos o teste

        //Act é quando executamos a ação que será testada

        //Assert é para verificar se o resultado está correto

    }
    [Fact]
    public void Dado_Um_Comando_Valido_deve_criar_a_tarefa()
    {
        //Arrange é quando preparamos o teste

        //Act é quando executamos a ação que será testada
        //Assert é para verificar se o resultado está correto

    }
}