using HardwareInventory.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace HardwareInventory.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
