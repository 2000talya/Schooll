using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bl.Conversion
{
    public class MarksConverters
    {
        ////DAL to DTO
        public static marksDTO GetDTO(Dal.Mark marks)
        {
            marksDTO dto = new marksDTO();
            dto.Code = marks.Code;
            dto.StudentId = marks.StudentId;
            dto.TaskCode = marks.TaskCode;
            return dto;
        }
        //DTO to DAL
        public static Dal.Mark GetEntity(marksDTO markDto)
        {
            Dal.Mark Entity = new Dal.Mark();
            Entity.Code = markDto.Code;
            Entity.StudentId = markDto.StudentId;
            Entity.TaskCode = markDto.TaskCode;
            Entity.Mark1 = markDto.Mark1;
            return Entity;
        }
    }
}
