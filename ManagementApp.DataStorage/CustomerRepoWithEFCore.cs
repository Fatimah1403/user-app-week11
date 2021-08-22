using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementApp.Models;


namespace ManagementApp.DataStorage
{
    public class CustomerRepoWithEFCore : ICustomerRepo
    {
       public async Task<bool> Add(Customer customer)
       {
            using (BusinessLogicDbContext context = new BusinessLogicDbContext())
            {
                await context.Customers.AddAsync(customer);
                   var result = await context.SaveChangesAsync();

                   return result > 0;
            }
       }
        public async Task<Customer> Login(string password, string email)
        {
            using (BusinessLogicDbContext context = new BusinessLogicDbContext())
                 

            {
            
                  Customer customer = await context.Customers
                 .FirstOrDefaultAsync(customer => customer.Email == email && customer.Password == password);
           
               

                    return customer;

             //          var customer = await context.Customers
             //    .Where(custmer => customer.Email == email && customer.Password == password)
             //    .FirstAsync();

              //  var customer = await context.Customers
              //    .Where(custmer => customer.Email == email && customer.Password == password)
              //    .FirstAsync();
            }

        }
         

            





    }
}