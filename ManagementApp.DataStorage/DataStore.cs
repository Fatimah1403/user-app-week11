using System.Collections.Generic;
using System.IO;

namespace ManagementApp.DataStorage
{
    public class DataStore
    {

        public async static void WriteToFileAsync()
        {
            string filePath = "../ManagementApp.DataStorage/RegisterationDetails.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            StreamWriter streamwrite = File.CreateText(filePath);
            await streamwrite.DisposeAsync();
            //Checking if user exists before writing
            //var existingCustomer = await ReadCustomerFromFileAsync(customer);
            //if ((existingCustomer.Equals(null)))
            //{
            using (StreamWriter streamWriter = File.AppendText(filePath))
             {
                 string CustomerDetails = $"{customer.CustomerID}|{customer.FirstName}|{customer.LastName}|{customer.Email}|{customer.Password}|{customer.ConfirmPassword}";
                streamWriter.WriteLine(CustomerDetails);
                await streamWriter.DisposeAsync();
            }

        }
        public async static void ReadToFileAsync()
        {
            using (StreamReader streamReader = File.OpenText(filePath))
         
             string fileContent = await streamReader.ReadToEndAsync();

             fileContent = fileContent.TrimEnd();

             string[] userRow = fileContent.Split(Environment.Newline);
             
         
             string fileContent = await streamReader.ReadToEndAsync();

             fileContent = fileContent.TrimEnd();

             string[] userRow = fileContent.Split(Environment.Newline);
             {
                  string CustomerDetails = $"{customer.CustomerID}|{customer.FirstName}|{customer.LastName}|{customer.Email}|{customer.Password}|{customer.ConfirmPassword}";
                streamWriter.WriteLine(CustomerDetails);
                await streamWriter.DisposeAsync();

             }

              
                
            
        }


            
            
            
             

         
        
            

           
            
        

        
                
    }
}