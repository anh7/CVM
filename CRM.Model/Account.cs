using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Models
{
    [Table("Account")]
    public class Account
    {
        
        [Key]
        public int ID { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string FirstName { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string LastName { get; set; }
        //[Required]
        public string EmailAddress { get; set; }
        public DateTime CreateDate { get; set; }

        //[MaxLength(30)]
        public string Password { get; set; }

        public int RoleID { get; set; }

        public virtual Role role { get; set; }
        public Account()
        {
            role = new Role();
        }

       
    }
}