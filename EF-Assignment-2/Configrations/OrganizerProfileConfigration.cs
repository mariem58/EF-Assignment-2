
using EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Assignment_2.Configrations
{
    internal class OrganizerProfileConfigration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(p => p.OrganizerProfileId);

            builder.Property(p => p.OrganizerProfileId)
                   .UseIdentityColumn(10, 10);

            builder.Property(p => p.Biography)
                   .HasColumnName("OrganizerBiography")
                   .HasColumnType("varchar")
                   .HasMaxLength(500);

            builder.HasOne(p => p.Organizer)
                   .WithOne(o => o.Profile)
                   .HasForeignKey<OrganizerProfile>(p => p.OrganizerId)
                   .IsRequired();
        }
    }
}
