using EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment_2.Configrations
{
    internal class OrganizerProfileConfigration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrganizerProfile> builder)
        {
            throw new NotImplementedException();
        }
    }
}
