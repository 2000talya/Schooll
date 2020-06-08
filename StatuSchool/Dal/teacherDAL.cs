using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class teacherDAL
    {
        public static bool CommitTeacher(Teacher teacher)
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    db.Teachers.Add(teacher);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static User GetStudentById(string id)
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    //check status also
                    User student = db.Users.Where(u => u.Id == id).FirstOrDefault();
                    return student;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<User> GetStudentByName(string firstname, string lastname)
        {
            try
            {
                using (SchoolEntities db = new SchoolEntities())
                {
                    //check status also
                    List <User> students = db.Users.Where(u => u.FirstName == firstname && u.LastName == lastname).ToList();
                    return students;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
