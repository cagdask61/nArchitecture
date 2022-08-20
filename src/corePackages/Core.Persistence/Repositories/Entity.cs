namespace Core.Persistence.Repositories;

public class Entity
{
    public int Id { get; set; }

    public Entity()
    {
    }

    public Entity(int id) : this()
    {
        Id = id;
    }
}


public class Entity<TKey>
{
    public TKey Id { get; set; }

    public Entity()
    {
    }

    public Entity(TKey id) : this()
    {
        Id = id;
    }
}