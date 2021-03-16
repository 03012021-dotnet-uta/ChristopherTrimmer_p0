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
    public class ComponentRepository : IComponentRepository
    {
        public readonly PizzaBoxContext context;
        public ComponentRepository()
        {
            context = new PizzaBoxContext();
        }

        public ComponentRepository(PizzaBoxContext pizzaBoxContext)
        {
            context = pizzaBoxContext;
        }

        public List<AComponent> GetAll()
        {
            return context.Components.ToList();
        }

        public AComponent GetComponent(int componentId)
        {
            return context.Components.Find(componentId);
        }

        public void Insert(AComponent component)
        {
            context.Components.Add(component);
        }

        public void Update(AComponent component)
        {
            context.Entry(component).State = EntityState.Modified;
        }

        public void Delete(int orderId)
        {
            var order = context.Orders.Find(orderId);
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
