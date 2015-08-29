using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class Advisor
    {
        public int AdvisorID { get; set; }
        [Required()]
        public string AdvisorName { get; set; }
        [Required()]
        public string AEmail { get; set; }
        public string APhone { get; set; }
        public string ACell { get; set; }
        public string AArea { get; set; }
        [Required]
        [StringLength(9)]
        public string AUsername { get; set; }
        [Required()]
        [DataType(DataType.Password)]
        public string APassword { get; set; }
    }
}