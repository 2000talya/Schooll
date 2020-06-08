using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Dal
{

    public class studentDal
    {
        public static bool CommitStudent(Student s)
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    db.Students.Add(s);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}