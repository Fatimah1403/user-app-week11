using ManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.DataStorage;


namespace ManagementApp.BL
{
    public class BusinessLogic : IBusinessLogic
    {
        public readonly IStoreRepo _storeRepo;

        public BusinessLogic(IStoreRepo storeRepo)
        {
            _storeRepo = storeRepo ?? throw new ArgumentNullException(nameof(storeRepo));
        }
        // public static IBusinessLogic cBusinessLogic;
        // public bool Login(string name, string password)
        // {
        //     throw new System.Exception("Login Unsuccessfull");
        // }
        public async Task<Store> CreateSupermarket(string name, string Products, string customerId)
        {
            Store store = new Store
            {
                Name = name,
                Products = Products,
                CustomerId = customerId

            };

            var result = await _storeRepo.Add(store);
            if (result)
                return store;
            throw new System.Exception("unable to create a supermarket store");

        }

        public async Task<Store> CreateKiosk(string name, string products, string customerId)
        {
            Store store = new Store
            {
                Name = name,
                Products = products,
                CustomerId = customerId
            };
            var result = await _storeRepo.Add(store);
            if (result)
                return store;
            throw new System.Exception("unable to create a kiosk store");

        }
        public Task<bool> AddProductsToTheStore(int price, string storeNumber)
        {
            throw new System.Exception();
        }
        public Task<bool> RemoveProduct(string storeId, int productprice)
        {
            throw new System.Exception();
        }
        public Task<bool> DeleteStore(string storeId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetAllNumberOfStores(string mame, string storeNumber)
        {
            throw new System.Exception();
        }

        public Task<bool> Add(Store store)
        {
            throw new NotImplementedException();
        }

       public Task<Store> GetStoreDetails(string mame, string storeNumber, string storeType, int productprice)
        {
            throw new NotImplementedException();
        }

        int IBusinessLogic.GetStoreDetails(string mame, string storeNumber, string storeType, int productprice)
        {
            throw new NotImplementedException();
        }
    }
}