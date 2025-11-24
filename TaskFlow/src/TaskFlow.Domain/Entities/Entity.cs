namespace TaskFlow.Domain.Entities;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; private set; }

    protected Entity()
    {
        //Sempre gera um novo Guid ao criar a entidade
        Id = Guid.NewGuid();
    }

    public bool Equals(Entity? other)
    {
        return Id == other?.Id;
    }
}
