using ManagementApp.Models;
using System.Threading.Tasks;

namespace ManagementApp.BL
{
    public interface ICustomerActions
    {
        Task<bool> Add(Customer customer);

        Task<Customer> AddCustomer(string lastName, string firstName, string email, string password);
        Task<Customer> Login(string email, string password);

    }
}