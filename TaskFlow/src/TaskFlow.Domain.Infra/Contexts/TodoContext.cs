
using Microsoft.EntityFrameworkCore;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Domain.Infra.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<TodoItem> TodoItems { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>().ToTable("TodoItems");
        modelBuilder.Entity<TodoItem>().Property(t => t.Id);
        modelBuilder.Entity<TodoItem>().Property(t => t.Title).HasMaxLength(200);
        modelBuilder.Entity<TodoItem>().Property(t => t.Description).HasMaxLength(1000);
        modelBuilder.Entity<TodoItem>().Property(t => t.Done).IsRequired();
        modelBuilder.Entity<TodoItem>().Property(t => t.Date);
        modelBuilder.Entity<TodoItem>().Property(t => t.User).HasMaxLength(100);
    }
}