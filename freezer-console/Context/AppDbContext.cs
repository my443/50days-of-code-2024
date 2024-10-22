using freezer_console.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace freezer_console.Context
{
    public  class AppDbContext: DbContext 
    {
        public DbSet<Models.Container> Container { get; set; }
        public DbSet<Connection> Connections{ get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=myapp.db");
        }

        
    }
}
