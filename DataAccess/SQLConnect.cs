using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class SQLConnect:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PNBU9NR;DataBase=ReservationApp;Trusted_Connection=true");
        }

        public DbSet<Train> Trains { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Carriage> Carriages { get; set; }

    }
}
