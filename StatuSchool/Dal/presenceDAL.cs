using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class PresenceDal
    {
        public static List<Presence> GetPresenceById(string id)
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    List<Presence> presence = db.Presences.Where(p => p.StudentId == id).ToList();
                    return presence;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
