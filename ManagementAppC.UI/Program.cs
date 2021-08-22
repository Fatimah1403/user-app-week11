using Microsoft.Extensions.DependencyInjection;
using System;
using ManagementApp.BL;
using ManagementApp.DataStorage;
using Microsoft.Extensions.DependencyInjection;

namespace ManagementAppC.UI
{
    class Program
    {
        private static IServiceProvider serviceProvider;

        static void Main(string[] args)
        {
            // ADO dataConnection = new ADO();
            // //  var result3 = dataConnection.InsertUsingtoredProcedures("ola","teniola", "motun").Result;

            // // var3 result = dataConnection.InsertIntoCustomerActions("ola","teniola", "motun").Result;
            // // var result2 = dataConnection.InsertIntoCustomerActions("rildwan", "olu", 4).Result;
            // // var result4 = dataConnection.InsertUsingtoredProcedures("James", "Olu", "fayy@2gmail.com", "Jayo", "John23").Result;




            ConfigureServices();
            ICustomerActions customerAction = serviceProvider.GetRequiredService<ICustomerActions>();
            IBusinessLogic businessLogic = serviceProvider.GetRequiredService<IBusinessLogic>();
            try
            {
                DashBoard dashboard = new DashBoard(customerAction, businessLogic);
                dashboard.DisplayDashBoard().Wait();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to start application");
            }

        }
        private static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<ICustomerActions, CustomerActions>();
            services.AddScoped<IStoreRepo, StoreRepo>();

            services.AddScoped<IBusinessLogic, BusinessLogic>();
            // services.AddScoped<ICustomerRepo, CustomerRepo>();



            serviceProvider = services.BuildServiceProvider();
        }

    }
}
