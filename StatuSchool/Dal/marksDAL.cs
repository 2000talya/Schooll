using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MarksDal
    {
        public static List<Mark> GetMarksById(string id)
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    List<Mark> marks = db.Marks.Where(m => m.StudentId == id).ToList();
                    return marks;
                }
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
