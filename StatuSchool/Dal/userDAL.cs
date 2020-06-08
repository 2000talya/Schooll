using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class userDAL
    {

        public static bool Register(User u)
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    //u.status=false;
                    db.Users.Add(u);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static User Login(string id, string password)
        {
            try
            {
                Dal.User user = new User();
                using (SchoolEntities db = new SchoolEntities())
                {
                    user = db.Users.Where(u => u.Id == id && u.Password == password).FirstOrDefault();
                    if (user != null)
                        return user;
                }
                return null;

            }
            catch (Exception)
            {
                return null;
            }
          
        }
    }
}
