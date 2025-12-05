using System;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Tests.Domain.Tests.EntityTests;

public class TodoItemTests
{
    private readonly TodoItem _todoItem = new TodoItem("Ajustar Planilha", "Planilha financeiro 10.08, ajustar para o database", DateTime.UtcNow, "Matheus");

    [Fact]
    public void Dado_um_novo_todoitem_o_mesmo_nao_pode_ser_concluido()
    {
        Assert.False(_todoItem.Done);
    }
}