using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class Profile
    {
        [Key]
        [ForeignKey("User")]
        public int UserID { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("Student ID")]
        public string Username { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email ID")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNo { get; set; }
        [Required]
        [DisplayName("Course Name")]
        public string Course { get; set; }

        public virtual User User { get; set; }
    }
}