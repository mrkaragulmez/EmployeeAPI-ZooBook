using System;

namespace Employee.Infrastructure.Base;

public interface IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
}