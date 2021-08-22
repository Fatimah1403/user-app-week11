using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;
using ManagementApp.BL;
using Moq;
using ManagementApp.Models;
using ManagementApp.DataStorage;
using System;

namespace TestApp
 {
    public class BusinessLogicCustomerTest
    {
        // private  ICustomerRepo customerRepo;

        // [SetUp]
        // public void Setup()
        // {
        //       var  mockICustomerRepo = new Mock<ICustomerRepo>() 

        //      .Setup(repos => repos.Add(It.IsAny<String>()))
        //      .Returns(Task.FromResult());
        //     customerRepo = mockICustomerRepo.Object;
             

        // }

        // [Test]
        // public async Task CustomerActions_Add_Method_when_successful()
        // {
        //     // Arrange

        //     CustomerActions customerActions = new CustomerActions(_customerActions);
        //     string firstName = "Fatimah";
        //     string lastName = "Hassan";
        //     string email = "fatty@gmail.com";
        //     string password = "Omokehinde";

        //     //   Act 
        //     Customer customer = await customerActions.AddCustomer(lastName, firstName, email, password);
        //     // Assert 
        //     Assert.IsNotNull(customer);
        //     Assert.AreEqual(customer.FirstName, firstName);
        //     Assert.AreEqual(customer.LastName, lastName);
        //     Assert.AreEqual(customer.Email, email);
        //     Assert.AreEqual(customer.Password, password);



        //     //  var = mockICustomerRepo = new Mock<ICustomerRepo>();
        //     // mockICustomerRepo
        //     // .Setup(repos => repos.Add(It.IsAny<Customer>()))
        //     // .Returns(Task.FromResult(false));
        //     // _CustomerActions = mockICustomerActions.Object;

        // }

        // [Test]
        // public void CustomerActions_Add_Method_when_Not_successful()
        // {
        //     // Arrange

        //     // CustomerActions customerActions =  new CustomerActions(_customerRepo);
        //     string firstName = "Fatimah";
        //     string lastName = "Hassan";
        //     string email = "fatty@gmail.com";
        //     string password = "Omokehinde";


        //     //  Act & Assert
        //     Assert.ThrowsAsync<System.Exception>(
        //         async () =>
        //     await customerActions.AddCustomer(lastName, firstName, email, password));

            
        // }



    }
}