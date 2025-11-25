namespace TaskFlow.Domain.Entities;

public class TodoItem : Entity
{
    #region Properties
    public string Title { get; private set; }
    public bool Done { get; private set; }
    public DateTime Date { get; private set; }
    public string User { get; private set; }
    #endregion
    #region Constructors
    public TodoItem(string title, bool done, DateTime date, string user)
    {
        Title = title;
        Done = false;
        Date = date;
        User = user;
    }
    #endregion
    #region Methods
    //Marca a tarefa como concluída
    public void MarkAsDone()
    {
        Done = true;
    }
    //Marca a tarefa como não concluída
    public void MarkAsUndone()
    {
        Done = false;
    }
    public void UpdateTitle(string title)
    {
        Title = title;
    }
    #endregion
}