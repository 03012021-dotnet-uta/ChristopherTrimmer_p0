using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Topping : AComponent
    {
        public Topping()
        {
            
        }
    }

    public class Mozzarella : Topping
    {
        public Mozzarella()
        {
            Name = "Mozzarella";
            Price = 1.00m;
            PizzaId = 4;
        }
    }

    public class Pepperoni : Topping
    {
        public Pepperoni()
        {
            Name = "Pepperoni";
            Price = 1.00m;
            PizzaId = 4;
        }

    }

    public class GroundBeef : Topping
    {
        public GroundBeef()
        {
            Name = "Ground Beef";
            Price = 1.00m;
            PizzaId = 4;
        }   

    }

    public class Onions : Topping
    {
        public Onions()
        {
            Name = "Onions";
            Price = 1.00m;
            PizzaId = 4;
        }   

    }    
    public class Mushrooms : Topping
    {
        public Mushrooms()
        {
            Name = "Mushrooms";
            Price = 1.00m;
            PizzaId = 4;
        }   

    }
    
}

