using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Entities;
using WindVane.Domain.Interfaces;

namespace WindVane.PiliPala.Domain.Models
{
    public class Category : Entity, IAggregateRoot
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
