using System;
using System.Collections.Generic;


namespace CampNetwork.Models
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Attachments = new List<Attachment>();
            Comments = new List<Comment>();
        }

        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public int? CampPlaceID { get; set; }
        public virtual CampPlace CampPlace { get; set; }
    }
}
