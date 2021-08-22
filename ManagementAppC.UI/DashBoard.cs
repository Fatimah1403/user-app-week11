using System;
using ManagementApp.BL;
using ManagementApp.Commons;
using ManagementApp.Models;
using System.IO;
using ManagementApp.DataStorage;
using System.Threading.Tasks;


namespace ManagementAppC.UI
{
    public class DashBoard
    {
        private readonly ICustomerActions _customerActions;
        private readonly IBusinessLogic cbusinessLogic;
        public DashBoard(ICustomerActions customerActions, IBusinessLogic businessLogic)
        {
            _customerActions = customerActions ?? throw new ArgumentNullException(nameof(customerActions));
            cbusinessLogic = businessLogic ?? throw new ArgumentNullException(nameof(businessLogic));
        }


        private static string firstName;

        private static string lastName;

        private static string emailAddress;

         private static string password;



        public async Task DisplayDashBoard()
        {
            bool shouldRun = true;
            while (shouldRun)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Welcome to my store management app.");

                Console.WriteLine("Enter your details:  ");
                Console.WriteLine("1 to Register");
                Console.WriteLine("2 to Login");
                Console.WriteLine("0 to exit");


                var consoleInput = Validations.IsvalidInput(Console.ReadLine());
                if (consoleInput == -1)
                {
                    Console.WriteLine("Please enter a valid input");
                    Console.Clear();
                }
                Console.WriteLine("Enter a username:  ");
                string UserId1 = Console.ReadLine();
                Console.WriteLine("Enter a password:  ");
                string Pass = Console.ReadLine();
                string UserIdCorrect = "test1";
                String PassCorrect = "password1";
                int MaxAttempts = 6;

                Console.ReadKey();
                if (UserId1 != UserIdCorrect && Pass != PassCorrect)
                {
                    MaxAttempts++;

                }
                else
                    break;
                {
                    if (MaxAttempts > 6)
                    {
                        Console.WriteLine("Login Failed");

                    }
                    else
                        Console.WriteLine("Login Successful");
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
                                password = Console.ReadLine();
                                Console.WriteLine("Enter your password");
                                var customer = await _customerActions.AddCustomer(firstName, lastName, emailAddress, password);
                                Console.WriteLine($"Customer {customer.FullName} added successfully");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                            catch (Exception ex)  //Catches all unforseen errors
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Enter first name");
                                firstName = Console.ReadLine();
                                Console.WriteLine("Enter last name");
                                lastName = Console.ReadLine();
                                Console.WriteLine("Enter email address"); 
                                emailAddress = Console.ReadLine();
                                password = Console.ReadLine();
                                Console.WriteLine("Enter your password");
                                var customer = await _customerActions.AddCustomer(firstName, lastName, emailAddress, password);
                                Console.WriteLine($"Customer {customer.FullName} added successfully");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                        case 3:
                            try
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                        case 4:
                            try
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                        case 0:
                            try
                            {
                                Console.WriteLine("weldone.");
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