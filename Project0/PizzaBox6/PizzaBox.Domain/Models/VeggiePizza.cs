using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class VeggiePizza : APizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";   
        }

        public override void AddCrust()
        {
            AComponents.Add(new ThinCrust());
        }

        public override void AddSize()
        {
            AComponents.Add(new MediumSize());
        }

        public override void AddToppings()
        {
            AComponents.Add(new Mozzarella());
            AComponents.Add(new Onions());
            AComponents.Add(new Mushrooms());

        }

    }
}