using System.Threading.Tasks;
using ManagementApp.Models;


namespace ManagementApp.BL

{
    public interface ICustomerRepo
    {
        Task<bool> AddCustomer(string firstName, string LastName, string email, string password);
        Task<bool> Add(string customer);
         Task<Customer> Login(string email, string password);
        


    }
}