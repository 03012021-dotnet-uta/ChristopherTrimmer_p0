using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing.Repositories.Interfaces;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{

    /// <summary>
    /// Each controller instantiates the respective IRepo interface for each DBSet.
    /// IRepo interface holds the CRUD functions.
    /// Each DBSet has a respective implementation Repo
    /// </summary>

    public class PizzaController
    {
        private IPizzaRepository iPizzaRepository;

        public PizzaController()
        {
            iPizzaRepository = new PizzaRepository(new PizzaBoxContext());
        }

        public List<APizza> GetPizzas()
        {
            var pizzas = iPizzaRepository.GetAll();
            return pizzas;
        }

        public APizza AddPizza(APizza pizza)
        {
            iPizzaRepository.Insert(pizza);
            iPizzaRepository.Save();
            return pizza;
        }

        public APizza GetPizza(int pizzaId)
        {
            APizza pizza = iPizzaRepository.GetPizza(pizzaId);
            return pizza;
        }


        public void Update(APizza pizza)
        {
            iPizzaRepository.Update(pizza);
            iPizzaRepository.Save();
        }

        public void Delete(int pizzaId)
        {
            iPizzaRepository.Delete(pizzaId);
            iPizzaRepository.Save();
        }        


    }
}