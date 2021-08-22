using System.Threading.Tasks;
using System.IO;
using ManagementApp.Models;
using System.Text;
using System.Collections.Generic;

namespace ManagementApp.DataStorage
{
    public class StoreRepoWithEFCore 
    {
            public async Task<bool> Add(Store store)
            {
               using (BusinessLogicDbContext context = new BusinessLogicDbContext())
                {
                  await context.Stores.AddAsync(store);
                   var result = await context.SaveChangesAsync();

                   return result > 0;
 
                }

            }
            public Task<bool> AddProducts(string storeId, int amount)
            {
                throw new System.Exception();
            }
            public Task<bool> GetStoreDetails(string store)
            {
                throw new System.Exception();
            }


            public Task<bool> GetStore(string storeId)
            {
                throw new System.Exception();
            }

            public Task<bool> RemoveProducts(string store)
            {
                throw new System.Exception();
            }
            public Task<bool> Delete(string storeId)
            {
                throw new System.Exception();
            }


        
    }
    
}