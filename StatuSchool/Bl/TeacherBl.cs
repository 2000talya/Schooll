using System;
using Dto;
using System.Collections.Generic;

namespace Bl
{
    public class TeacherBl
    {
        public static bool CommitTeacher(teacherDTO t)
        {
            Dal.Teacher teacher = Bl.Conversion.TeacherConverters.GetEntity(t);
            return Dal.teacherDAL.CommitTeacher(teacher);
        }

        public static userDTO GetStudentById(string id)
        {
            Dal.User student = Dal.teacherDAL.GetStudentById(id);
            return Bl.Conversion.UserConverters.GetDTO(student);
        }

        public static List <userDTO> GetStudentByName(string firstname, string lastname)
        {
            List <Dal.User> students = Dal.teacherDAL.GetStudentByName(firstname, lastname);
            List<Dto.userDTO> s = new List<userDTO>();
            foreach (var item in students)
            {
                s.Add(Bl.Conversion.UserConverters.GetDTO(item));
            }
            return s;
        }

    }
}