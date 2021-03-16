using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class CheesePizza : APizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";   
        }

        public override void AddCrust()
        {
            AComponents.Add(new RegularCrust());
        }

        public override void AddSize()
        {
            AComponents.Add(new MediumSize());
        }

        public override void AddToppings()
        {
            AComponents.Add(new Mozzarella());
        }

    }
}