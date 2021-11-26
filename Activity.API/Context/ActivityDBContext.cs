using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Activity.API.Models;

namespace Activity.API.Context
{
    public class ActivityDBContext : DbContext
    {
        public ActivityDBContext(DbContextOptions options) : base(options)
        {
            
        }

       public DbSet<Models.Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Activity>().Property(e=>e.Id).ValueGeneratedOnAdd();

        }
    }
}
