using TaskFlow.Domain.Entities;

namespace TaskFlow.Domain.Repositories;

public interface ITodoRepository
{
    void Create(TodoItem todo);
    void Update(TodoItem todo);
    void DeleteTodo(int id);

}
