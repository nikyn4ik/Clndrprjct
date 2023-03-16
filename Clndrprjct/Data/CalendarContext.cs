using Clndrprjct.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Clndrprjct.Data
{
    public class CalendarContext : DbContext
    {
        public CalendarContext(DbContextOptions<CalendarContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
        public DbSet<Reminder> Reminders { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reminder>()
                .HasOne(e => e.User)
                .WithMany(e => e.Reminders)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reminder>()
                .HasOne(e => e.CalendarEvent)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CalendarEvent>()
                .HasOne(e => e.User)
                .WithMany(e => e.CalendarEvents)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CalendarEvents)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reminders)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
