using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Entities;

namespace WindVane.PiliPala.Domain.Events.Category
{
    public class CategoryCreatedEvent : Event
    {
        public CategoryCreatedEvent(string name, string description, string icon, string link, bool isPublished, int displayOrder)
        {
            Name = name;
            Description = description;
            Icon = icon;
            Link = link;
            IsPublished = isPublished;
            DisplayOrder = displayOrder;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool IsPublished { get; set; }
        public int DisplayOrder { get; set; }
    }
}
