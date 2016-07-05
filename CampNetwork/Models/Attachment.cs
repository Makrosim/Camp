using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampNetwork.Models
{
    public class Attachment : BaseEntity
    {
        public string Type { get; set; } // Add Enum
        public byte[] Bytes { get; set; }

        public User User { get; set; }
        public Article Article { get; set; }
    }
}
