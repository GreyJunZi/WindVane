using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindVane.PiliPala.Domain.Events.Menu;

namespace WindVane.PiliPala.Domain.EventHandlers.Menu
{
    public class MenuEventHandler :
        INotificationHandler<MenuCreatedEvent>,
        INotificationHandler<MenuUpdatedEvent>,
        INotificationHandler<MenuRemovedEvent>
    {
        public Task Handle(MenuCreatedEvent @event, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MenuUpdatedEvent @event, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(MenuRemovedEvent @event, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
