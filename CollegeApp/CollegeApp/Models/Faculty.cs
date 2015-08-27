using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeApp.Models
{
    public class Faculty
    {
        public int FacultyID { get; set; }
        [Required(ErrorMessage="First name required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="Last name required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage="Age required")]
        public int Age { get; set; }
        [Required(ErrorMessage="Qualification required")]
        public string Qualification { get; set; }
        [Required(ErrorMessage="Salary Required")]
        public decimal Salary { get; set; }
    }
}