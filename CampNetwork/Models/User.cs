using System;
using System.Collections.Generic;

namespace CampNetwork.Models
{
    public class User : BaseEntity
    {
        public User()
        {
            CampPlaces = new List<CampPlace>();
            Groups = new List<Group>();
            Dialogs = new List<Dialog>();
            Friends = new List<User>();
            Attachment = new List<Attachment>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string AdditionalInformation { get; set; }
        public virtual ICollection<Attachment> Attachment { get; set; }
        public virtual ICollection<CampPlace> CampPlaces { get; set; }
        public ICollection<Group> Groups { get; set; }
        public UserSetting UserSettings { get; set; }
        public ICollection<User> Friends { get; set; }
        public ICollection<Dialog> Dialogs { get; set; }
    }
}
