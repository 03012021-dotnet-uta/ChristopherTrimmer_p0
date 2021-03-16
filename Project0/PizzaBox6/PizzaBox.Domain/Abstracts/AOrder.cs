using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Abstracts
{


    /// <summary>
    /// AOrder is base class for all Orders.
    /// It is a DbSet.
    /// </summary>
    ///     
    public partial class AOrder
    {
        // Primary key
        public int AOrderId { get; set; }

        // Foreign key tied to Customer that creates the order
        public int CustomerId { get; set; }

        // Foreign key tied to Pizza that is part of the order
        public int PizzaId {get; set;}

        // Foreign key tied to the store where order is created
        public int StoreId { get; set; }

        public ACustomer Customer { get; set; }

        [NotMapped]
        public APizza Pizza { get; set; }

        public AStore Store {get; set;}


        // Each order stores a collection of pizzas
        public ICollection<APizza> Pizzas {get; set;}

        public AOrder()
        {
            Pizzas = new HashSet<APizza>();   
        }
    }
}