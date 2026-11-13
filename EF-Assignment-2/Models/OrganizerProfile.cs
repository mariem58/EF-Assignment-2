using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment_2.Models
{
    internal class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }
        public string? Biography { get; set; }
        public string? Website { get; set; }
        public string? Logo { get; set; }
        public int OrganizerId { get; set; }

        public Organizer Organizer { get; set; } = null!;
    }
}
