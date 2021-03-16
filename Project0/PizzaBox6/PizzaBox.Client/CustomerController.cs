using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Storing.Repositories;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Storing.Repositories.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{

    /// <summary>
    /// Each controller instantiates the respective IRepo interface for each DBSet.
    /// IRepo interface holds the CRUD functions.
    /// Each DBSet has a respective implementation Repo
    /// </summary>

    public class CustomerController
    {
    
        private ICustomerRepository iCustomerRepository;

        public CustomerController()
        {
            iCustomerRepository = new CustomerRepository(new PizzaBoxContext());
        }

        public List<ACustomer> GetCustomers()
        {
            var customers = iCustomerRepository.GetAll();
            return customers;
        }

        public ACustomer AddCustomer(ACustomer customer)
        {
            iCustomerRepository.Insert(customer);
            iCustomerRepository.Save();
            return customer;
        }

        public void UpdateCustomer(ACustomer customer)
        {
            iCustomerRepository.Update(customer);
            iCustomerRepository.Save();
        }

        public void DeleteCustomer(int customerId)
        {
            iCustomerRepository.Delete(customerId);
            iCustomerRepository.Save();
        }

    }
}