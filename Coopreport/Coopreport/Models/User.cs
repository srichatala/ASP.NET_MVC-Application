using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("User Name")]
        public string Username { get; set; }
        [Required]
        [StringLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}