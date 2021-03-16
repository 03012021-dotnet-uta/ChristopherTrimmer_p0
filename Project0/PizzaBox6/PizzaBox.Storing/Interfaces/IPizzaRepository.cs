using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repositories.Interfaces
{
    /// <summary>
    /// Repo Interface for each DbSet.
    /// Defines the base CRUD operations for each Repo.
    /// </summary>
    public interface IPizzaRepository
    {
        List<APizza> GetAll();
        APizza GetPizza(int pizzaId);

        void Insert(APizza customer);

        void Update(APizza customer);

        void Delete(int customerId);

        void Save();
    }
}