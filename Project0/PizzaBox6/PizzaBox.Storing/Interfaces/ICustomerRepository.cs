using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repositories.Interfaces
{
    /// <summary>
    /// Repo Interface for each DbSet.
    /// Defines the base CRUD operations for each Repo.
    /// </summary>
    public interface ICustomerRepository
    {
        List<ACustomer> GetAll();
        ACustomer GetCustomer(int customerId);

        void Insert(ACustomer customer);

        void Update(ACustomer customer);

        void Delete(int customerId);

        void Save();

    }
}