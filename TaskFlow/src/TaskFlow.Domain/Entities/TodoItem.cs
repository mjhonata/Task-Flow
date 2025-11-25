namespace TaskFlow.Domain.Entities;

public class TodoItem : Entity
{
    public string Title { get; private set; }
    public bool Done { get; private set; }
    public DateTime Date { get; private set; }
    public string User { get; private set; }
    public TodoItem(string title, bool done, DateTime date, string user)
    {
        Title = title;
        Done = done;
        Date = date;
        User = user;
    }
}