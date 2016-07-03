using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CampNetwork.Models
{
    public class CampContext : DbContext
    {
        public CampContext() : base("CampContext")
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupSetting> GroupSettings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }
        public DbSet<Dialog> Dialogs { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<CampPlace> CampPlaces { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
