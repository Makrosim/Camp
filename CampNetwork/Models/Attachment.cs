using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampNetwork.Models
{
    public class Attachment : BaseEntity
    { 
        public string Type { get; set; }
        public Article Article { get; set; }
    }
}
