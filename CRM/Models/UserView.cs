using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class UserView
    {
        [Required]
        public String LastName { get ; set ;}
        [Required]
        public String FirstName { get; set; }
        //[Required]
        public String Password { get; set; }
        public String Email { get; set; }
        public int RoleID { get; set; }
        public DateTime DateCreate { get; set; }
        public UserView() { }
    }
}