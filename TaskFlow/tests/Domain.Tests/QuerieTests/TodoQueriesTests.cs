using TaskFlow.Domain.Entities;
using Xunit;
using System.Collections.Generic;
using System.Reflection;

namespace TaskFlow.Domain.Queries;

public class TodoQueriesTests
{
    private List<TodoItem> _items;

    public TodoQueriesTests()
    {
        _items = new List<TodoItem>();
        _items.Add(new TodoItem("Tarefa 1", "Descricao 1", DateTime.UtcNow, "user1"));
        _items.Add(new TodoItem("Tarefa 2", "Descricao 2", DateTime.UtcNow, "user2"));
        _items.Add(new TodoItem("Tarefa 3", "Descricao 3", DateTime.UtcNow, "user1"));
        _items.Add(new TodoItem("Tarefa 4", "Descricao 4", DateTime.UtcNow, "user3"));
        _items.Add(new TodoItem("Tarefa 5", "Descricao 5", DateTime.UtcNow, "user2"));


    }
    [Fact]
    public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario()
    {
        // Arrange é quando preparamos o teste
        var result = _items.AsQueryable().Where(TodoQueries.GetAll("user1"));
        // Act é quando executamos o teste
        // Assert é quando verificamos o resultado
        Assert.Equal(2, result.Count());
    }
}