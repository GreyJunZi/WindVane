using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Interfaces;

namespace WindVane.Domain.Entities
{
    public abstract class Entity : Entity<Guid>
    {
        public DateTime? Created { get; protected set; }
        public DateTime? Updated { get; protected set; }
    }

    public abstract class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
    }
}
