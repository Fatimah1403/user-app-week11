using System;
using System.ComponentModel.DataAnnotations;


namespace ManagementApp.Models
{
    public class Store
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string StoreType { get; set; }
        public string Products { get; set; }
        [Required]
        public string CustomerId { get; set; }
    }

}