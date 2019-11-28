using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Entities;

namespace WindVane.PiliPala.Domain.Events.Category
{
    public class CategoryRemovedEventd : Event
    {
        public CategoryRemovedEventd(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
