using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repositories.Interfaces
{
    /// <summary>
    /// Repo Interface for each DbSet.
    /// Defines the base CRUD operations for each Repo.
    /// </summary>
    public interface IComponentRepository
    {
        List<AComponent> GetAll();
        AComponent GetComponent(int componentId);

        void Insert(AComponent component);

        void Update(AComponent component);

        void Delete(int orderId);

        void Save();

    }
}