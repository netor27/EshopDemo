using Basket.API.IntegrationEvents.Events;
using Demo.BuildingBlocks.EventBus.Abstractions;
using Demo.Services.Basket.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.IntegrationEvents.EventHandling
{
    public class OrderStartedIntegrationEventHandler : IIntegrationEventHandler<OrderStartedIntegrationEvent>
    {
        private readonly IBasketRepository _repository;
        public OrderStartedIntegrationEventHandler(IBasketRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(OrderStartedIntegrationEvent @event)
        {
            await _repository.DeleteBasketAsync(@event.UserId.ToString());
        }
    }
}



