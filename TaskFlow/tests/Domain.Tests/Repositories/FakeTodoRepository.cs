<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
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
    public TodoItem GetById(Guid id, string user)
    {
        // Simula a recuperação de uma tarefa por ID e usuário
        return new TodoItem("Título de Teste", "Descrição de Teste", DateTime.Now, user);
    }

}
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Domain.Entities;
    using Domain.Repositories;
namespace Domain.Tests.Repositories;
    public class FakeTodoRepository : ITodoRepository
    {
        
    }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
