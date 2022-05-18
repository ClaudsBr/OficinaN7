using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OficinaN7.Models;

namespace OficinaN7.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Client> Clients {get;set;}
        public DbSet<Service> Services {get;set;}
        public DbSet<Schedule> Schedules {get;set;}
        public DbSet<Address> Addresses {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
