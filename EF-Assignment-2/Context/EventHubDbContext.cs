using EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment_2.Context
{
    internal class EventHubDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHub;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>().ToTable("OrganizerProfiles");
            modelBuilder.Entity<OrganizerProfile>().HasKey(o => o.OrganizerProfileId);
            modelBuilder.Entity<OrganizerProfile>().Property(o => o.OrganizerProfileId)
                .UseIdentityColumn(10, 10);

            modelBuilder.Entity<OrganizerProfile>().Property(o => o.Biography)
                .HasColumnName("OrganizerBiography")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();



              

        }
    }
}
