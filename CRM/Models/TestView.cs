using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class TestView
    {
        [Display(Name = "Test Name")]
        public String TestName { get; set; }
        [Display(Name = "Des")]
        public String Des { get; set; }
    }
}