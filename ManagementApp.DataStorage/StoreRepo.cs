using System.Threading.Tasks;
using System.IO;
using ManagementApp.Models;



namespace ManagementApp.DataStorage
{
    public class StoreRepo : IStoreRepo
    {
        public Task<bool> Add(Store store)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AddProducts(string storeId, int amount)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(string storeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> GetStore(string storeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> GetStoreDetails(string store)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveProducts(string store)
        {
            throw new System.NotImplementedException();
        }

        public class CustomerRepo
        {
            public readonly FileInfo fileInfo;
            public string FilePath = "../ManagementApp.DataStorage/StoreApp.txt";
            public CustomerRepo()
            {
                fileInfo = new FileInfo(FilePath);
            }
            public async Task<bool> Add(Store store)
            {
                try
                {
                    if (File.Exists(FilePath))
                        File.Delete(FilePath);
                    {
                        StreamWriter streamwrite = File.CreateText(FilePath);
                        await streamwrite.DisposeAsync();
                    }
                    using (StreamWriter streamWriter = File.AppendText(FilePath))
                    {
                        string StoreDetails = $"{store.Name}|{store.Id}|{store.StoreType}|{store.CustomerId}|{store.Products}";
                        streamWriter.WriteLine(StoreDetails);
                        await streamWriter.DisposeAsync();
                    }


                }
                catch (System.Exception)
                {
                    return false;
                }
                return true;
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
}