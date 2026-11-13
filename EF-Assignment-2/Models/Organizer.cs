using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Assignment_2.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {

        [Key]
        public int OrganizerID { get; set; }
        [Required]
        [MaxLength(100)]
        public string? OrganizerName { get; set; }
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        // Navigation Properties
        public OrganizerProfile Profile { get; set; }

    }
}
