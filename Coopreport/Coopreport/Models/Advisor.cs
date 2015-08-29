using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class Advisor
    {
        public int AdvisorID { get; set; }
        [Required()]
        [DisplayName("Advisor Name")]
        public string AdvisorName { get; set; }
        [Required()]
        [DisplayName("Email ID")]
        public string AEmail { get; set; }
        [DisplayName("Phone Number")]
        public string APhone { get; set; }
        [DisplayName("Cell Number")]
        public string ACell { get; set; }
        [DisplayName("Area")]
        public string AArea { get; set; }
        [Required]
        [StringLength(9)]
        [DisplayName("User Name")]
        public string AUsername { get; set; }
        [Required()]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string APassword { get; set; }
    }
}