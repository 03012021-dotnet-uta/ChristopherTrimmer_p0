using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class CustomPizza : APizza
    {

        public CustomPizza()
        {
            Name = "Custom Pizza";
        }

        public override void AddCrust()
        {
           // base.AddCrust();
        }

        public override void AddSize()
        {
           // base.AddSize();
        }

        public override void AddToppings()
        {
         //   base.AddToppings();
        }

    }
}