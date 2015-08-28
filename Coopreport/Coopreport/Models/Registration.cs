using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Coopreport.Models
{
    public class Registration
    {
        
        public int RegistrationID { get; set; }

        [StringLength(9)]
        [Required]
        [DisplayName("Student ID")]
        [RegularExpression("^([0-9 .&'-]+)$", ErrorMessage = "Enter valid student id")]
        public string StudentID { get; set; }

        [Required]
        [DisplayName("First Name")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid First Name")]
        public string SFName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid Last Name")]
        public string SLName { get; set; }

        [Required]
        [DisplayName("Program Name")]
        [RegularExpression("^([a-zA-Z0-9 .&'-]+)$", ErrorMessage = "Invalid Program Name")]
        public string SProgram { get; set; }

        [Required]
        [DisplayName("Email ID")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid Email Address")]
        public string SEmail { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Provience { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }

        [Required]
        public string Password { get; set; }

    }
}