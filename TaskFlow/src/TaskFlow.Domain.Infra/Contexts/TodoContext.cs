
using Microsoft.EntityFrameworkCore;

namespace TaskFlow.Domain.Infra.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

}