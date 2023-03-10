using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clndrprjct.Models;

namespace Clndrprjct.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CalendarEvent> CalendarEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<CalendarEvent>()
                .HasOne(ce => ce.User)
                .WithMany(u => u.CalendarEvents)
                .HasForeignKey(ce => ce.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
