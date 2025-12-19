using TaskFlow.Domain.Entities;

namespace TaskFlow.Domain.Repositories;

public interface ITodoRepository
{
    void Create(TodoItem todo);
    void Update(TodoItem todo);
    void DeleteTodo(int id);
    TodoItem GetById(Guid id, string user);
    IEnumerable<TodoItem> GetAll(string email);
    IEnumerable<TodoItem> GetAllDone(string email);
    IEnumerable<TodoItem> GetAllUndone(string email);
    IEnumerable<TodoItem> GetByPeriod(string email, DateTime date, bool done);

}
