
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Assignment_2.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        [Key]
        public int OrganizerID { get; set; }

        [Required]
        [MaxLength(100)]
        public string OrganizerName { get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public OrganizerProfile Profile { get; set; } = null!;

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
