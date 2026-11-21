
using EF_Assignment_2.Configrations;
using EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Assignment_2.Context
{
    internal class EventHubDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=EventHub;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfigration());
            modelBuilder.ApplyConfiguration(new EventConfigration());
            modelBuilder.ApplyConfiguration(new BadgeConfigration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
