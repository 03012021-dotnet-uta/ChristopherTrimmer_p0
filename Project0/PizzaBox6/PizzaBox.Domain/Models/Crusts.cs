using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Crust : AComponent
    {
        public Crust()
        {
            
        }
    }

    public class DeepDishCrust : Crust
    {
        public DeepDishCrust()
        {
            Name = "Deep Dish Crust";
            Price = 3.00m;
            PizzaId = 4;
        }
    }

    public class ThinCrust : Crust
    {
        public ThinCrust()
        {
            Name = "Thin Crust";
            Price = 1.00m;
            PizzaId = 4;
        }

    }

    public class RegularCrust : Crust
    {
        public RegularCrust()
        {
            Name = "Regular Crust";
            Price = 2.00m;
            PizzaId = 4;
        }   

    }

    
}

