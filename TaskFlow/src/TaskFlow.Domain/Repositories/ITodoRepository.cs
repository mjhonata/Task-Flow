namespace TaskFlow.Domain.Repositories;

public interface ITodoRepository
{
    void Create(string title, string description);
    void Update(int id, string title, string description);
    void DeleteTodo(int id);

}
