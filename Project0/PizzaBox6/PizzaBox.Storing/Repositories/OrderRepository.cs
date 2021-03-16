using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PizzaBox.Storing.Repositories.Interfaces;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
    /// <summary>
    /// Each DbSet has a respective IRepo and Repo for communication to DB
    /// Repos implement the IRepo functions and perform the CRUD communication
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        public readonly PizzaBoxContext context;
        public OrderRepository()
        {
            context = new PizzaBoxContext();
        }

        public OrderRepository(PizzaBoxContext pizzaBoxContext)
        {
            context = pizzaBoxContext;
        }

        public List<AOrder> GetAll()
        {
            return context.Orders.ToList();
        }

        public AOrder GetOrder(int orderId)
        {
            return context.Orders.Find(orderId);
        }

        public void Insert(AOrder order)
        {
            var ord = new AOrder()
            {
                StoreId = order.StoreId,
                CustomerId = order.CustomerId
            };
            context.Orders.Add(order);
        }

        public void Update(AOrder order)
        {
            context.Entry(order).State = EntityState.Deleted;
        }

        public void Delete(int orderId)
        {
            AOrder order = context.Orders.Find(orderId);
            context.Entry(order).State = EntityState.Deleted;
            context.Orders.Remove(order);
        }

        public void Save()
        {
            context.SaveChanges();
        }
        
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
