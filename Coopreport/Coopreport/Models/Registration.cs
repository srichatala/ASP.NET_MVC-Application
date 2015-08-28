using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public Int64 StudentID { get; set; }
        public string SFName { get; set; }
        public string SLName { get; set; }
        public string SProgram { get; set; }
        public string SEmail { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string SProvience { get; set; }
        public string PostalCode { get; set; }
        public string SPhone { get; set; }
        public string SCell { get; set; }
        public string SPassword { get; set; }

    }
}