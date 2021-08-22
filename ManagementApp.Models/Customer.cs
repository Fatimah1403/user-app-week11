using System;
using System.Collections.Generic;
using ManagementApp.Models;
using ManagementApp.Commons;
using System.ComponentModel.DataAnnotations;

namespace ManagementApp.Models
{
    public class Customer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        private string firstName;
        [Required]
        public string FirstName
        {
            get { return firstName; }
             set { firstName = Validations.CleanName(value); }
        }
        private string lastName;
        [Required]
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
        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = " Your Password is invlaid")]
        public string Password { get; set; }



    }
}