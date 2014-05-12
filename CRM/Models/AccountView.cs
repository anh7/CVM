using CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CRM.Model
{
    public class AccountView
    {
       
            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }


            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email Address")]
            public string Email { get; set; }

       
            [Display(Name = "Password")]
            public string Password { get; set; }


            [Display(Name = "Role")]
            public int  RoldeID { get; set; }

            public DateTime DateCreate { get; set; }

            public AccountView()
            {

            }

            public AccountView(Account account)
            {
                this.FirstName = account.FirstName;
                this.LastName = account.LastName;
                this.Password = account.Password;
                //this.RoldeID = account.
                this.Email = account.EmailAddress;
                this.DateCreate = account.CreateDate;
            }

        }
    
}