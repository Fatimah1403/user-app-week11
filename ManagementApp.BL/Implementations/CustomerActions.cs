using System.Collections.Generic;
using System;
using System.Text;
using ManagementApp.DataStorage;
using ManagementApp.Models;
using ManagementApp.Commons;
using System.Threading.Tasks;


namespace ManagementApp.BL  
{
    public class CustomerActions : ICustomerActions 
    {
        private readonly ICustomerActions _customerActions;
        public CustomerActions(ICustomerActions customerActions)
        {
             _customerActions = customerActions ?? throw new ArgumentNullException(nameof(customerActions));
        }

        public Task<bool> Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer>  AddCustomer(string lastName, string firstName, string email, string password)
        {
            if (!Validations.IsEmailValid(email))
             throw new FormatException("Email is not valid");
              Customer customer = new Customer
              {
                  FirstName = firstName,
                  LastName = lastName,
                  Email = email,
                  Password = password

              };
            

             var result = await _customerActions.Add(customer);
             if (result)
                return customer;
                throw new TimeoutException("unable to create a user");


        }

        public async Task<Customer> Login(string email, string password)
        {
            var result = await _customerActions.Login(email, password);
            return result;
        } 
    }
}


   


    