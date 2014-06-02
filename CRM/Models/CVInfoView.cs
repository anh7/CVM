using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class CVInfoView
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Country { get; set; }
        public DateTime DoB { get; set; }
        public String Occupation { get; set; }
        public String Email { get; set; }
        public String Mobile { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public String City { get; set; }

        public CVInfoView() { }
    }
}