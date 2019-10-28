using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using WindVane.Domain.Interfaces;

namespace WindVane.Domain.Entities
{
    public abstract class Event : IEvent, INotification
    {
        public DateTime Timestamp { get; private set; }
        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
