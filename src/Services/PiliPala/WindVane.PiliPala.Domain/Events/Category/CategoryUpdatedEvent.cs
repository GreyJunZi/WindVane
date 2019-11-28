using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Entities;

namespace WindVane.PiliPala.Domain.Events.Category
{
    public class CategoryUpdatedEvent : Event
    {

        public CategoryUpdatedEvent(Guid id, string name, string description, string icon, string link, bool isPublished, int displayOrder)
        {
            Id = id;
            Name = name;
            Description = description;
            Icon = icon;
            Link = link;
            IsPublished = isPublished;
            DisplayOrder = displayOrder;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool IsPublished { get; set; }
        public int DisplayOrder { get; set; }
    }
}
