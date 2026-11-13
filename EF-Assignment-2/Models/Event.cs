using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment_2.Models
{
    internal class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxAttendees { get; set; }


        public int OrganizerId { get; set; }
        public Organizer organizer { get; set; } = null!;
    }
}
