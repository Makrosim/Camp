using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampNetwork.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Article Article { get; set; }
    }
}
