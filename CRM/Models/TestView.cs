using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class InterestingView
    {
        public String primary { get; set; }
        public String secondary { get; set; }
        public String image { get; set; }
        public String onclick { get; set; }
    }
}