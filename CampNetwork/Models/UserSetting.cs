using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampNetwork.Models
{
    public class UserSetting : BaseEntity
    {
        [Key]
        [ForeignKey("User")]
        public new int Id { get; set; }
        public User User { get; set; }
    }
}
