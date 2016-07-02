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
                AdditionalInformation = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer non odio et massa accumsan ultrices. In vel faucibus justo. Ut condimentum nunc in nisl volutpat, eu placerat tellus tincidunt. Sed posuere orci at felis imperdiet iaculis pretium sed orci. Interdum et malesuada fames ac ante ipsum primis in faucibus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Suspendisse magna sapien, luctus ac lobortis sit amet, ullamcorper et metus. Ut ac consectetur metus, et consectetur turpis. Nam non nisl turpis. Fusce vulputate ipsum quam, sit amet pretium mauris mollis vel. Phasellus vitae finibus erat. Proin et tortor non dui consectetur sodales vitae vitae elit. Donec vitae pulvinar est. Proin tincidunt est dui, sed convallis orci congue sed. Curabitur tortor dui, rhoncus sed quam in, luctus accumsan orci. Mauris vitae varius odio. ",
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