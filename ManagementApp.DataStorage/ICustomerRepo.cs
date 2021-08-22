using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Models;
using System;

namespace ManagementApp.DataStorage
{
    public interface ICustomerRepo
    {
        Task<bool> Add(Customer customer);
        Task<Customer> Login(string password, string email);
    }
}