using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampNetwork.Models
{
    public class GroupSetting : BaseEntity
    {
        [Key]
        [ForeignKey("Group")]
        public new int Id { get; set; }
        public Group Group { get; set; }
    }
}
