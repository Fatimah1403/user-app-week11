using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Models;

namespace ManagementApp.DataStorage
{
    public interface IStoreRepo
    {
          Task<bool> Add(Store store);
          Task<bool> AddProducts(string storeId, int amount);
           Task<bool> GetStoreDetails(string store);
           Task<bool> GetStore(string storeId);
           Task<bool> RemoveProducts(string store);
            Task<bool> Delete(string storeId);
            
    }
}