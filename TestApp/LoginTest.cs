using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;
using ManagementApp.BL;
using Moq;
using ManagementApp.Models;
using ManagementApp.DataStorage;
namespace TestApp
{
    public class LoginTest
    {
        // private readonly ICustomerRepo customerRepo;

        // private void Setup(string email, string password)
        // {
        //     var = mockICustomerRepo = new Mock<ICustomerRepo>();
        //     mockICustomerRepo

        //     .Setup(repos => repos.Login(email, password))
        //     .Returns(Task.FromResult(new Customer { Email  = email, Password = password}));

        //     _customerRepo = mockICustomerRepo.Object;
        // }
        // [Test]

        // public async Task CustomerActions_Login_when_successful()
        // {
        //     //Arrange
        //     string password = "keny01";
        //     string email = "lolade@qwomentechsters";

        //        //Act
        //    Setup(email, password);
        //     CustomerActions customerActions = new CustomerActions(_CustomerActions);


        //     //Assert
        //     CustomerActions ccustomerActions = await customerActions.Login(password, email);
        //     Assert.IsNotNull(customer);
        //     Assert.AreEqual(customer.Email, email);
        //     Assert.AreEqual(customer.Password, password);

           


        // }


    }
}