using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class MeatPizza : APizza
    {
        public MeatPizza()
        {
            Name = "Meat Pizza";   
        }

        public override void AddCrust()
        {
            AComponents.Add(new DeepDishCrust());
        }

        public override void AddSize()
        {
            AComponents.Add(new LargeSize());
        }

        public override void AddToppings()
        {
            AComponents.Add(new Mozzarella());
            AComponents.Add(new Pepperoni());
            AComponents.Add(new GroundBeef());
        }

    }
}