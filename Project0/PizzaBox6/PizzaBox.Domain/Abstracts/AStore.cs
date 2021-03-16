using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{

    /// <summary>
    /// APizza is base class for all pizzas.
    /// It is a DbSet.
    /// </summary>
    ///  
     
    public class AStore
    {
        // Primary Key
        public int AStoreId { get; set; }
        public string Name { get; set; }

        // Collection to store the orders created at this store
        public ICollection<AOrder> AOrders { get; set; }

        public AStore()
        {
            AOrders = new HashSet<AOrder>();
        }
    }
}
