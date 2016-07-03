using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampNetwork.Models
{
    public class Comment : BaseEntity
    {
        public User Author { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Article Article { get; set; }
    }
}