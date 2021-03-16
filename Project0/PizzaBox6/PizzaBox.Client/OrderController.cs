using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing.Repositories.Interfaces;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{

    /// <summary>
    /// Each controller instantiates the respective IRepo interface for each DBSet.
    /// IRepo interface holds the CRUD functions.
    /// Each DBSet has a respective implementation Repo
    /// </summary>

    public class OrderController
    {
        private IOrderRepository iOrderRepository;

        public OrderController()
        {
            iOrderRepository = new OrderRepository(new PizzaBoxContext());
        }

        public List<AOrder> GetOrders()
        {
            var orders = iOrderRepository.GetAll();
            return orders;
        }
        
        public AOrder AddOrder(AOrder order)
        {
            iOrderRepository.Insert(order);
            iOrderRepository.Save();
            return order;
        }

    }
}