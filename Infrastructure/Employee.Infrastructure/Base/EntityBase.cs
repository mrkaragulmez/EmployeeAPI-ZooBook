using System;

namespace Employee.Infrastructure.Base;

public class EntityBase : IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}