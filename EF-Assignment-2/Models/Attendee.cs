using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Assignment_2.Models
{
    internal class Attendee
    {
        [Key]
        public int AttendID { get; set; }
        [Required]
        [MaxLength(150,ErrorMessage ="Full Name Can not be greater than 150 character")]
        public string FullName { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Email Can not be greater than 200 character")]
        public string Email { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "Street Can not be greater than 200 character")]
        public string Street { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "City Can not be greater than 200 character")]
        public string City { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Country Can not be greater than 200 character")]
        public string Country { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Country Can not be greater than 200 character")]
        [Column("ZipCode")]
        public string PostalCode { get; set; }

        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {Country}, {PostalCode}";
    }
}
