using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PizzaBox.Storing.Repositories;
using PizzaBox.Storing.Repositories.Interfaces;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Client
{

    /// <summary>
    /// Each controller instantiates the respective IRepo interface for each DBSet.
    /// IRepo interface holds the CRUD functions.
    /// Each DBSet has a respective implementation Repo
    /// </summary>

    public class ComponentController
    {
        private IComponentRepository iComponentRepository;

        public ComponentController()
        {
            iComponentRepository = new ComponentRepository(new PizzaBoxContext());            
        }

        public List<AComponent> GetComponents()
        {
            var components = iComponentRepository.GetAll();
            return components;
        }

        public AComponent AddComponent(AComponent component)
        {
            iComponentRepository.Insert(component);
            iComponentRepository.Save();
            return component;
        }

        public AComponent GetComponent(int componentId)
        {
            AComponent component = iComponentRepository.GetComponent(componentId);
            return component;
        }



    }
}