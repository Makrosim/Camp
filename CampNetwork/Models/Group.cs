using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampNetwork.Models
{
    public class Group
    {
        public Group()
        {
            Members = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public virtual User Creator { get; set; }
        public ICollection<User> Members { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public GroupSetting GroupSetting { get; set; }
    }
}
