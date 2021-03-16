using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{

    /// <summary>
    /// ACustomer is base class for all Customers.
    /// It is a DbSet.
    /// </summary>
    /// 
    public partial class ACustomer
    {
        // Primary Key
        public int ACustomerId { get; set; }
        public string Name { get; set; }

        // Collection to hold orders submitted by the user
        public ICollection<AOrder> AOrders { get; set; }

        public ACustomer()
        {
            AOrders = new HashSet<AOrder>();
        }


    }
}