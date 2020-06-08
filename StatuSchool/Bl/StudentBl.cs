using System;
using Dto;

namespace Bl
{
    public class StudentBl
    {
        public static bool CommitStudent(studentDTO student)
        {
            Dal.Student s = Bl.Conversion.StudentConverters.GetEntity(student);
            return Dal.studentDal.CommitStudent(s);
        }

     
    }
}