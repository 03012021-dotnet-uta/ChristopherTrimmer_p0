using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class PizzaSizes : AComponent
    {
        public PizzaSizes()
        {
            
        }
    }

    public class LargeSize : PizzaSizes
    {
        public LargeSize()
        {
            Name = "Large Size";
            Price = 10.00m;
            PizzaId = 4;
        }
    }

    public class MediumSize : PizzaSizes
    {
        public MediumSize()
        {
            Name = "Medium Size";
            Price = 8.00m;
            PizzaId = 4;
        }

    }

    public class SmallSize : PizzaSizes
    {
        public SmallSize()
        {
            Name = "Small Size";
            Price = 6.00m;
            PizzaId = 4;
        }  

    }

    
}

