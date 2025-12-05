using TaskFlow.Domain.Entities;
using TaskFlow.Domain.Repositories;
namespace TaskFlow.Tests.Domain.Tests.Repositories;

public class FakeTodoRepository : ITodoRepository
{
    public void Create(TodoItem todo)
    {
        // Simula a criação de uma tarefa (não faz nada)
    }
    public void Update(TodoItem todo)
    {
        // Simula a atualização de uma tarefa (não faz nada)
    }
    public void DeleteTodo(int id)
    {
        // Simula a exclusão de uma tarefa (não faz nada)
    }
}