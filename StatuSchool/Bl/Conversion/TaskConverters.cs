using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Conversion
{
    public class TaskConverters
    {
        ////DAL to DTO
        public static taskDTO GetDTO(Dal.Task tasks)
        {
            taskDTO dto = new taskDTO();
            dto.Code = tasks.Code;
            dto.SubjectCode = tasks.SubjectCode;
            dto.RequestDate = tasks.RequestDate;
            dto.PresentDate = tasks.PresentDate;
            dto.Tiltle = tasks.Tiltle;
            dto.Description = tasks.Description;
            dto.TeacherId = tasks.TeacherId;
            dto.ClassCode = tasks.ClassCode;
            return dto;
        }
        //DTO to DAL
        public static Dal.Task GetEntity(taskDTO taskDto)
        {
            Dal.Task Entity = new Dal.Task();
            Entity.Code = taskDto.Code;
            Entity.SubjectCode = taskDto.SubjectCode;
            Entity.RequestDate = taskDto.RequestDate;
            Entity.PresentDate = taskDto.PresentDate;
            Entity.Tiltle = taskDto.Tiltle;
            Entity.Description = taskDto.Description;
            Entity.TeacherId = taskDto.TeacherId;
            Entity.ClassCode = taskDto.ClassCode;
            return Entity;
        }
    }
}
