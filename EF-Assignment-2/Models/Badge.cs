using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assignment_2.Models
{

    public enum BadgeTier
    {
        Standard,
        VIP
    }
    internal class Badge
    {
        public int BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}
