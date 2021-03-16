using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{

    /// <summary>
    /// AComponent is base clase for Toppings, Crust, and Size
    /// It is a DbSet.
    /// </summary>

    public partial class AComponent
    {
        // Primary Key
        public int AComponentId { get; set; }
        public string Name { get; set; }

        public decimal Price {get; set;}

        // Foreign key to Pizza it is associated with
        public int PizzaId {get; set;}
        public APizza Pizza { get; set; }

        public AComponent()
        {
            
        }
    }
}