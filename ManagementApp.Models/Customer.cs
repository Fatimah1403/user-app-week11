using System;
using System.Collections.Generic;
using ManagementApp.Models;
using ManagementApp.Commons;

namespace ManagementApp.Models
{
    public class Customer
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
             set { firstName = Validations.CleanName(value); }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName;}
             set { lastName = Validations.CleanName(value);}
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string Email { get; set; }
        public string ID { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


        public string Product { get; set; }
        public string StoreDetails { get; set; }


    }
}