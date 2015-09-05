using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("Student ID/Employee ID")]
        public string Username { get; set; }
        [Required]
        [StringLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email ID")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNo { get; set; }
        [DisplayName("Course Name")]
        public string Course { get; set; }

    }
}