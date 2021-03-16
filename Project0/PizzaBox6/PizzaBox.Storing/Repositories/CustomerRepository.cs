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
    public class CustomerRepository : ICustomerRepository
    {
        public readonly PizzaBoxContext context;
        public CustomerRepository()
        {
            context = new PizzaBoxContext();
        }

        public CustomerRepository(PizzaBoxContext pizzaBoxContext)
        {
            context = pizzaBoxContext;
        }

        public List<ACustomer> GetAll()
        {
            return context.Customers.ToList();
        }

        public ACustomer GetCustomer(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public void Insert(ACustomer customer)
        {
            context.Customers.Add(customer);
        }

        public void Update(ACustomer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
        }

        public void Delete(int customerId)
        {
            ACustomer customer = context.Customers.Find(customerId);
            context.Entry(customer).State = EntityState.Deleted;
            context.Customers.Remove(customer);
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
