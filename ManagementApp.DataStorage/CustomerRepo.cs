using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Models;
using System;

namespace ManagementApp.DataStorage
{ 
    public class CustomerRepo : ICustomerRepo
    {
        private readonly FileInfo fileInfo;
       private string FilePath = "../ManagementApp.DataStorage/StoreApp.txt";
       public CustomerRepo()
       {
           fileInfo =new FileInfo(FilePath);
       }
       public async Task<bool> Add(Customer customer)
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
                    string CustomerDetails = $"{customer.FirstName}|{customer.LastName}|{customer.Email}|{customer.Password}";
                             streamWriter.WriteLine(CustomerDetails);
                               await streamWriter.DisposeAsync();
                }
                

           }
            catch (System.Exception)
           {
               return false;
           }
           return true;
       }
        public async Task<Customer> Login(string password, string email)
        {
            try
            {
               if (File.Exists(FilePath)) 
                 File.Delete(FilePath);
               {
                    throw new ArgumentNullException(nameof(FilePath));
                   
               } 
               #pragma warning disable

               using (StreamReader reader = File.OpenText(FilePath))
               {
                   var read = await reader.ReadToEndAsync();
                   read = read.TrimEnd();
                   var users = read.Split(Environment.NewLine);
                   foreach (var item in users)
                   {
                       var splittedItem = item.Split(',');
                       if (splittedItem[1] == email && splittedItem[4] == password)
                       {
                           return new Customer
                           {
                               Id = splittedItem[0],
                               Email = splittedItem[1],
                               FirstName = splittedItem[2],
                               LastName = splittedItem[3],
                               Password = splittedItem[4]
                           };
                       }

                   }

               }
            }
            catch (Exception)
            {
                
            }
                throw new UnauthorizedAccessException("Invalid details, enter valid details");

           #pragma warning restore
        }

       
    
    }       
      
}