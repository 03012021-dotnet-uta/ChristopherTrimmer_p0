using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Customer : ACustomer
    {
        public Customer()
        {
            Name = "Customer";
        }

        public Customer(string n)
        {
            Name = n;
        }
    }
}