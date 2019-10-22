using System;
using System.Collections.Generic;
using System.Text;

namespace WindVane.Domain.Interfaces
{
    public interface IValueObject : IValueObject<Guid>
    {
    }

    public interface IValueObject<T>
    {
        T Id { get; set; }
    }
}
