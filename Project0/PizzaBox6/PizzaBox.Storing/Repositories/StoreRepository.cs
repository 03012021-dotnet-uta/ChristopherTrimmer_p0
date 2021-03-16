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
    public class StoreRepository : IStoreRepository
    {
        public readonly PizzaBoxContext context;
        public StoreRepository()
        {
            context = new PizzaBoxContext();
        }

        public StoreRepository(PizzaBoxContext pizzaBoxContext)
        {
            context = pizzaBoxContext;
        }

        public List<AStore> GetAll()
        {
            return context.Stores.ToList();
        }

        public AStore GetStore(int storeId)
        {
            return context.Stores.Find(storeId);
        }

        public void Update(AStore store)
        {
            context.Entry(store).State = EntityState.Modified;
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
