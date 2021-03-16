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

    public class StoreController
    {
        private IStoreRepository iStoreRepository;

        public StoreController()
        {
            iStoreRepository = new StoreRepository(new PizzaBoxContext());
        }

        public List<AStore> GetStores()
        {
            var stores = iStoreRepository.GetAll();
            return stores;
        }

        public void UpdateStore(AStore store)
        {
            iStoreRepository.Update(store);
            iStoreRepository.Save();
        }

        public AStore GetStore(int storeId)
        {
            AStore store = iStoreRepository.GetStore(storeId);
            return store;

        }

     

 
    }
}