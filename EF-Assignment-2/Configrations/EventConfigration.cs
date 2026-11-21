
using EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_2.Configrations
{
    internal class EventConfigration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.EventID);

            builder.Property(e => e.Title)
                   .IsRequired();

            builder.Property(e => e.Description)
                   .IsRequired();

            builder.HasOne(e => e.Organizer)
                   .WithMany(o => o.Events)
                   .HasForeignKey(e => e.OrganizerId)
                   .IsRequired();
        }
    }
}
