using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1DB_framework.entities
{
    internal class BancoDB: DbContext
    {

        public DbSet<Aplicaçãofinanceira> aplicaçãofinanceiras { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }
    }
}
