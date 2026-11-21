
using EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_2.Configrations
{
    internal class BadgeConfigration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.BadgeNumber);

            builder.Property(b => b.Tier)
                   .HasConversion<string>();

            builder.HasOne(b => b.Attendee)
                   .WithOne(a => a.Badge)
                   .HasForeignKey<Badge>(b => b.AttendeeId)
                   .IsRequired();
        }
    }
}
