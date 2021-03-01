using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class TeamContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NNE3V2L\MSSQLDATABASE;Database=TeamDB;Trusted_Connection=True");                           
        }
        public DbSet<Player> Players { get; set; }
    }
}
