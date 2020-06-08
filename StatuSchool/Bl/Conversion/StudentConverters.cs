using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Conversion
{
    public class StudentConverters
    {
        
        //DAL TO DTO
        public static studentDTO GetDTO(Dal.Student student)
        {
            studentDTO dto = new studentDTO();
            dto.Id = student.Id;
            dto.ClassCode = student.ClassCode;
            return dto;
        }
        //DTO TO DAL
        public static Dal.Student GetEntity(studentDTO studentDto)
        {
            Dal.Student Entity = new Dal.Student();
            Entity.Id = studentDto.Id;
            Entity.ClassCode = studentDto.ClassCode;
            return Entity;
        }
    }
}
