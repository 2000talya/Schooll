using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl.Conversion
{
    public class TeacherConverters
    {
        //DAL to DTO
        public static teacherDTO GetDTO(Dal.Teacher teacher)
        {
            teacherDTO dto = new teacherDTO();
            dto.Id = teacher.Id;
            return dto;
        }
        //DTO to DAL
        public static Dal.Teacher GetEntity(teacherDTO teacherDto)
        {
            Dal.Teacher Entity = new Dal.Teacher();
            Entity.Id = teacherDto.Id;
            return Entity;
        }
    }
}
