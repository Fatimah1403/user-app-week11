using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ManagementApp.Models;


namespace ManagementApp.DataStorage
{
    
    public class BusinessLogicDbContext : DbContext
    {
       public DbSet<Customer> Customers { get; set; }

       public DbSet<Store> Stores { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder options)
       {
           options.UseSqlServer
            (@"Data Source=  DESKTOP-MB66D5H;Initial Catalog= ManagementApp;Integrated Security=True");
       }


    }

}