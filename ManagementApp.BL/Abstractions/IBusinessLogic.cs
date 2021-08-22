using ManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementApp.BL

{
    public interface IBusinessLogic
    {
        Task<Store> CreateSupermarket(string name, string Products, string customerId);
        
        Task<bool> Add(Store store);
        Task<bool> AddProductsToTheStore(int price, string storeNumber);
        Task<bool> RemoveProduct(string storeId, int productprice);
        Task<Store> CreateKiosk(string name, string products, string customerId);
        Task<bool> GetAllNumberOfStores(string mame, string storeNumber);
         int GetStoreDetails(string mame, string storeNumber, string storeType, int productprice);
        Task<bool> DeleteStore(string storeId);
        
    }
}