using System;
using ManagementApp.BL;
using ManagementApp.Commons;
using ManagementApp.Models;
using System.IO;
using ManagementApp.DataStorage;

namespace ManagementAppC.UI
{
    public class DashBoards
    {

        private static string firstName;
        private static string lastName;
        private static string emailAddress;
        private static string product;
        private static string storeDetails;

        public static void DisplayDashBoard(CustomerActions actions)
        {
            bool shouldRun = true;
            while (shouldRun)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Welcome to my store management app.");

                Console.WriteLine("Enter your login details: ");
                Console.WriteLine("1 to Add products");
                Console.WriteLine("2 to Save changes");
                Console.WriteLine("3 to Remove Products");
                Console.WriteLine("4 to get number of Products");
                Console.WriteLine("5 to get Store details of a particular store");
                Console.WriteLine("6 to Display Store details accordingly");
                Console.WriteLine("7 to exit");
                Console.WriteLine(" 0 to Logout");


                var consoleInput = Validations.IsValidInput(Console.ReadLine());
                if (consoleInput == -1)
                {
                    Console.WriteLine("Please enter a valid input");
                    Console.Clear();
                }
                string username, password, username1, password1 = string.Empty;

                Console.WriteLine("Enter a username:  ");
                username = Console.ReadLine();
                Console.WriteLine("Enter a password:  ");
                password1 = Console.ReadLine();

                using (StreamReader sr = StreamReader(File.Open("../ManagementApp.DataStorage/RegisterationDetails.txt", FileMode.Open)))
                {
                    username1 = sr.ReadLine();
                    password1 = sr.ReadLine();
                    sr.Close();
                }
                if (username == username1 && password == password1)
                {
                    Console.WriteLine("Login Successful");

                }
                else
                {
                    Console.WriteLine("Login Failed");
                    Console.Read();
                }
                {
                    switch (consoleInput)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("Enter first name");
                                firstName = Console.ReadLine();
                                Console.WriteLine("Enter last name");
                                lastName = Console.ReadLine();
                                Console.WriteLine("Enter email address");
                                emailAddress = Console.ReadLine();
                                Console.WriteLine("Enter the  products");
                                 Product = Console.ReadLine();
                                Console.WriteLine("Enter store details");
                                storeDetails = Console.ReadLine();
                                Customer customer = actions.AddCustomer(firstName, lastName, emailAddress, NumOfProducts,storeDetails);
                                Console.WriteLine($"Customer {customer.FullName} added successfully");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (FormatException ex) //Catches all errors relating to argument formats operations
                            {

                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 2:
                            try
                            {
                                actions.SaveChanges();
                                Console.WriteLine("Changes saved");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 3:
                            try
                            {
                                var RemoveProduct = actions.DequeueProduct();
                                Console.WriteLine($"Product {dequeuedProduct.product} has been removed");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("product dequeued");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 4:
                            try
                            {
                                var product = actions.ShowProduct();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("number of products");

                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 5:
                            try
                            {
                                actions.StoreDetails();
                                Console.WriteLine("Details Gotten");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 6:
                            try
                            {
                                var storedetails = actions.DisplayStoreDetails();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Helpers.DisplayHistoryTable(storedetails);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 7:
                            try
                            {
                                actions.SaveChanges();
                                Console.WriteLine("Bye.");
                                shouldRun = false;
                            }
                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        
        
    }
}