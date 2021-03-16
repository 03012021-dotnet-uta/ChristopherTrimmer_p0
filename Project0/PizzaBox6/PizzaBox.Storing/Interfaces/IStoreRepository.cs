using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repositories.Interfaces
{
    /// <summary>
    /// Repo Interface for each DbSet.
    /// Defines the base CRUD operations for each Repo.
    /// </summary>
    public interface IStoreRepository
    {
        List<AStore> GetAll();
        
        AStore GetStore(int storeId);

        void Update(AStore store);

        
        void Save();

    }
}