using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Abstracts
{

    /// <summary>
    /// APizza is base class for all pizzas.
    /// It is a DbSet.
    /// </summary>
    ///             

    public class APizza
    {

        // Primary key
        public int APizzaId { get; set; }

        public string Name { get; set; }

        // Collection to hold the toppings, crust, and size of respective pizza
        public ICollection<AComponent> AComponents { get; set; }

        public ICollection<AOrder> AOrders { get; set; }
        public APizza()
        {
            AComponents = new HashSet<AComponent>();
            AOrders = new HashSet<AOrder>();
            FactoryMethod();
        }

        /// <summary>
        /// Use Factory pattern to the build pizzas
        /// </summary>
        protected virtual void FactoryMethod()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }

        public virtual void AddToppings(){}

        public virtual void AddCrust(){}

        public virtual void AddSize(){}
    }
}