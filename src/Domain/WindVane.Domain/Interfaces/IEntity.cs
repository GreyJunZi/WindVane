using System;
using System.Collections.Generic;
using System.Text;

namespace WindVane.Domain.Interfaces
{
    public interface IEntity : IEntity<Guid>
    {

    }
    public interface IEntity<T>
    {
        T Id { get; set; }

    }
}
