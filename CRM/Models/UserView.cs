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
        public String Phone { get; set; }
        public bool Gender { get; set; }
        public String ImagiePro { get; set; }
        public String Street { get; set; }
        public int? ProvinceID { get; set; } 
        public IEnumerable<int>  InterestingID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int RoleID { get; set; }
        public DateTime DateCreate { get; set; }
        public UserView() { }
    }
}