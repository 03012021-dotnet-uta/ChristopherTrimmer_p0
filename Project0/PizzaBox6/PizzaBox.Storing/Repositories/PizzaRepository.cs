using System;
using System.Collections.Generic;
using PizzaBox.Storing.Repositories.Interfaces;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.Storing.Repositories
{
    /// <summary>
    /// Each DbSet has a respective IRepo and Repo for communication to DB
    /// Repos implement the IRepo functions and perform the CRUD communication
    /// </summary>
    public class PizzaRepository : IPizzaRepository
    {
        public readonly PizzaBoxContext context;
        public PizzaRepository()
        {
            context = new PizzaBoxContext();
        }

        public PizzaRepository(PizzaBoxContext pizzaBoxContent)
        {
            context = pizzaBoxContent;
        }

        public List<APizza> GetAll()
        {
            return context.Pizzas.ToList();
        }

        public APizza GetPizza(int pizzaId)
        {
            return context.Pizzas.Find(pizzaId);
        }

        public void Insert(APizza pizza)
        {
            context.Pizzas.Add(pizza);
        }

        public void Update(APizza pizza)
        {
            context.Entry(pizza).State = EntityState.Modified;
        }

        public void Delete(int pizzaId)
        {
            APizza pizza = context.Pizzas.Find(pizzaId);
            context.Entry(pizza).State = EntityState.Deleted;
            context.Pizzas.Remove(pizza);
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
