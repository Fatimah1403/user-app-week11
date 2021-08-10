using System;
using ManagementApp.BL;
using ManagementAppC.UI;
using System.IO;

namespace ManagementAppC.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomerActions actions = new CustomerActions();
                DashBoard.DisplayDashBoard(actions);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to start application");
            }

        }
    }
}
