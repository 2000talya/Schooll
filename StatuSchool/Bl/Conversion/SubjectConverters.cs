using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Conversion
{
    public class SubjectConverters
    {
        //DAL TO DTO
        public static subjectDTO GetDTO(Dal.Subject subject)
        {
            subjectDTO dto = new subjectDTO();
            dto.Code = subject.Code;
            dto.Name = subject.Name;
            dto.TeacherId = subject.TeacherId;
            return dto;
        }
        //DTO TO DAL
        public static Dal.Subject GetEntity(subjectDTO subjectDto)
        {
            Dal.Subject Entity = new Dal.Subject();
            Entity.Code = subjectDto.Code;
            Entity.Name = subjectDto.Name;
            Entity.TeacherId = subjectDto.TeacherId;
            return Entity;
        }
    }
}
