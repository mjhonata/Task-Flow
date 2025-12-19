using TaskFlow.Domain.Entities;
using TaskFlow.Domain.Infra.Contexts;
using TaskFlow.Domain.Repositories;

namespace TaskFlow.Domain.Infra.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly DataContext _context;
    public void Create(TodoItem todo)
    {
        throw new NotImplementedException();
    }

    public void Update(TodoItem todo)
    {
        throw new NotImplementedException();
    }

    public void DeleteTodo(int id)
    {
        throw new NotImplementedException();
    }

    public TodoItem GetById(Guid id, string user)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TodoItem> GetAll(string email)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TodoItem> GetAllDone(string email)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TodoItem> GetAllUndone(string email)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TodoItem> GetByPeriod(string email, DateTime date, bool done)
    {
        throw new NotImplementedException();
    }
}