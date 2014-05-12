using CRM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int ID { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string Name { get; set; }
        public virtual IList<User> Users{get;set;}
      
    
    }
}
