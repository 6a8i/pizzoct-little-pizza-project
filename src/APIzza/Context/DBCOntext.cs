using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class DBCOntext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Payment> Payment { get; set; }

        public DBCOntext()
        {
        }
    }
}
