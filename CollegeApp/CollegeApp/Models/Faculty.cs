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
        [Required(ErrorMessage = "First name required")]
        [DisplayName("First Name")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "First Name should be between 5 t0 35")]
        //[RegularExpression(@"[a-zA-Z]",ErrorMessage=("Name should be in characters"))]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [StringLength(35, MinimumLength = 5, ErrorMessage = "First Name should be between 5 t0 35")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Range(0, 100, ErrorMessage = "Age should be 0 to 100")]
        [Required(ErrorMessage = "Age required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Qualification required")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Salary Required")]
        public decimal Salary { get; set; }

        public string Email { get; set; }
    }
}