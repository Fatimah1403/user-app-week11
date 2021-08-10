using System.Collections.Generic;
using System;
using ManagementApp.BL;
using ManagementApp.DataStorage;
using ManagementApp.Models;
using ManagementApp.Commons;

namespace ManagementApp.BL
{
    public class CustomerActions
    {
        private readonly DataStore store;
        public CustomerActions()
        {
            store = new DataStore();
            // store.ReadUsersDataFromFile();
        }
        public Customer AddCustomer(string lastName, string firstName, string email, string Product, string StoreDetails)
        {
            if (!Validations.IsEmailValid(email))
                throw new FormatException("Email is not valid");
            Customer newUser = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                // Product = product,
                StoreDetails = StoreDetails

            };
            // store.customer.Enqueue(NumOfProducts);
             return newUser;
        }
        public void SaveChanges()
        {
            store.WriteCustomerDataToFile();
        }

        // public void DequeueProducts()
        // {
        //     return store.Product.Dequeue();
        // }
        // public void EnqueueProducts()
        // {
        //     return store.Products.Enqueue();
        // }
        // public void  DisplayUsers()
        // {
        //     return store.users;
        // }

    }
}