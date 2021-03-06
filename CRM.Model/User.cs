﻿using CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public bool Status { get; set; }
        public DateTime ? DateCreate { get; set; }
        public String Phone { get; set; }
        
        public bool ? Gender { get; set; }

        public DateTime ? DateOfBirth { get; set; }
        public String ImagieProfile { get; set; }
        public int  RoleID { get; set; }




        public virtual Role role { get; set; }

        public virtual Address UserAddress { get; set; }
        public virtual List<User_Interesting> User_Interesting { get; set; }
        public virtual List<User_Education> User_Education { get; set; }
    }
}
