using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampNetwork.Models
{
    public class GroupSetting
    {
        [Key]
        [ForeignKey("Group")]
        public int Id { get; set; }
        public Group Group { get; set; }
    }
}
