using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CampNetwork.Models
{
    public class DbCampInitializer : DropCreateDatabaseAlways<CampContext>
    {
            
        protected override void Seed(CampContext db)
        { 
            User us1 = new User
            {
                FirstName = "Влад",
                LastName = "Клочков",
                BirthDate = DateTime.Parse("1995-02-25"),
                AdditionalInformation = "olololgccccccccccccccckhdkhdkhksjxjxfdultdlutdultdlutlyfykudtkykkydkskkhhd",
                Adress = "Харьков",
                Skype = "Makrosim_skype",
                Phone = "64646106460",
                UserSettings = new UserSetting { }
            };

            db.Users.Add(us1);
            db.SaveChanges();
        }
    }
}