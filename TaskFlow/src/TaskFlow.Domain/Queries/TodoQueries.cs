using System.Linq.Expressions;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Domain.Queries;
//usamos classe estatica para nao precisar instanciar. Não instanciar é necessário pq é uma query
public static class TodoQueries
{
    public static Expression<Func<TodoItem, bool>> GetAll(string user)
    {
        return x => x.User == user;
    }
    public static Expression<Func<TodoItem, bool>> GetAllDone(string user)
    {
        return x => x.User == user && x.Done;
    }
    public static Expression<Func<TodoItem, bool>> GetAllUndone(string user)
    {
        return x => x.User == user && !x.Done == false;
    }
    public static Expression<Func<TodoItem, bool>> GetByPeriod(string user, DateTime date, bool done)
    {
        return x =>
        x.User == user &&
        x.Done == done &&
        x.Date.Date == date.Date;
    }


}