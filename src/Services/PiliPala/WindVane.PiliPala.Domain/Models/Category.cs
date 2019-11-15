using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Entities;
using WindVane.Domain.Interfaces;

namespace WindVane.PiliPala.Domain.Models
{
    public class Category : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool IsPublished { get; set; }
        public int DisplayOrder { get; set; }

        public Category()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }
    }
}
