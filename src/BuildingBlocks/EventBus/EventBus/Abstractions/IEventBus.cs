using Demo.BuildingBlocks.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BuildingBlocks.EventBus.Abstractions
{
    public interface IEventBus
    {
        void Subscribe<T>(IIntegrationEventHandler<T> handler) where T: IntegrationEvent;
        void Unsubscribe<T>(IIntegrationEventHandler<T> handler) where T : IntegrationEvent;
        void Publish(IntegrationEvent @event);
    }
}
