using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repositories.Interfaces
{
    /// <summary>
    /// Repo Interface for each DbSet.
    /// Defines the base CRUD operations for each Repo.
    /// </summary>
    public interface IOrderRepository
    {
        List<AOrder> GetAll();
        AOrder GetOrder(int orderId);

        void Insert(AOrder order);

        void Update(AOrder order);

        void Delete(int orderId);
        void Save();

    }
}