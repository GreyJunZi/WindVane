using System;
using System.Collections.Generic;
using System.Text;

namespace WindVane.Domain.Interfaces
{
    public abstract class IEntity : IEntity<Guid>
    {

    }
    public abstract class IEntity<T>
    {
        T Id { get; set; }

    }
}
