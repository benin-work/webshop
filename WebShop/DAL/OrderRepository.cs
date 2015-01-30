﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebShop.Models;

namespace WebShop.DAL
{
    public class OrderRepository: GenericShopRepository<Order>
    {
        public OrderRepository(ShopContext context)
            : base(context)
        {
        }

        public Order CreateNewOrder()
        {
            int clientId = context.Clients.FirstOrDefault().ID;
            int productId = context.Clients.FirstOrDefault().ID;

            var order = new Order { ClientID = clientId };
            order.OrderItems = new List<OrderItem> { 
                new OrderItem{ProductID = productId}
            };

            return order;
        }
    }
}