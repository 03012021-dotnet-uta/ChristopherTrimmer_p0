using System;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public partial class PizzaBoxContext : DbContext
    {
        public DbSet<AStore> Stores {get;set;}
        public DbSet<ACustomer> Customers { get; set; }

        public DbSet<AOrder> Orders {get;set;}
        public DbSet<AComponent> Components {get;set;}

        public DbSet<APizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=500-409;Database=PizzaBox6NewDB;Trusted_Connection=True;");
        }
    }
}