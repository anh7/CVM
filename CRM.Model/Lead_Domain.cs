using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Models
{
    [Table("Lead_Domain")]
    public class Lead_Domain
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }

        public int LeadID { get; set; }
        public int DomainID { get; set; }

        [ForeignKey("LeadID")]
        public virtual Lead Lead { get; set; }
        [ForeignKey("DomainID")]
        public virtual Domain Domain { get; set; }

        public Lead_Domain()
        {

        }
    }
}
