﻿using System;
using MediatR;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Collections;

namespace Demo.Services.Ordering.API.Application.Commands
{
    // DDD and CQRS patterns comment: Note that it is recommended to implement immutable Commands
    // In this case, its immutability is achieved by having all the setters as private
    // plus only being able to update the data just once, when creating the object through its constructor.
    // References on Immutable Commands:  
    // http://cqrs.nu/Faq
    // https://docs.spine3.org/motivation/immutability.html 
    // http://blog.gauffin.org/2012/06/griffin-container-introducing-command-support/
    // https://msdn.microsoft.com/en-us/library/bb383979.aspx

    [DataContract]
    public class CreateOrderCommand
        :IAsyncRequest<bool>
    {
        [DataMember]
        private readonly List<OrderItemDTO> _orderItems;

        [DataMember]
        public string City { get; private set; }

        [DataMember]
        public string Street { get; private set; }

        [DataMember]
        public string State { get; private set; }

        [DataMember]
        public string Country { get; private set; }

        [DataMember]
        public string ZipCode { get; private set; }

        [DataMember]
        public string CardNumber { get; private set; }

        [DataMember]
        public string CardHolderName { get; private set; }

        [DataMember]
        public DateTime CardExpiration { get; private set; }

        [DataMember]
        public string CardSecurityNumber { get; private set; }

        [DataMember]
        public int CardTypeId { get; private set; }

        [DataMember]
        public int PaymentId { get; private set; }

        [DataMember]
        public int BuyerId { get; private set; }

        [DataMember]
        public IEnumerable<OrderItemDTO> OrderItems => _orderItems;

        public void AddOrderItem(OrderItemDTO item)
        {
            _orderItems.Add(item);
        }

        public CreateOrderCommand()
        {
            _orderItems = new List<OrderItemDTO>();
        }

        public CreateOrderCommand(string city, string street, string state, string country, string zipcode,
            string cardNumber, string cardHolderName, DateTime cardExpiration,
            string cardSecurityNumber, int cardTypeId, int paymentId, int buyerId) : this()
        {
            City = city;
            Street = street;
            State = state;
            Country = country;
            ZipCode = zipcode;
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            CardExpiration = cardExpiration;
            CardSecurityNumber = cardSecurityNumber;
            CardTypeId = cardTypeId;
            CardExpiration = cardExpiration;
            PaymentId = paymentId;
            BuyerId = buyerId;
        }

        public class OrderItemDTO
        {
            public int ProductId { get; set; }

            public string ProductName { get; set; }

            public decimal UnitPrice { get; set; }

            public decimal Discount { get; set; }

            public int Units { get; set; }

            public string PictureUrl { get; set; }
        }
    }
}
