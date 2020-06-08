using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;
namespace Bl.Conversion
{
    public class ClassesConverters
    {
        ////DAL to DTO
        public static classDTO GetDTO(Dal.Class classes)
        {
            classDTO dto = new classDTO();
            dto.Code = classes.Code;
            dto.Grade = classes.Grade;
            dto.NumClass = classes.NumClass;
            return dto;
        }
        //DTO to DAL
        public static Dal.Class GetEntity(classDTO classDto)
        {
            Dal.Class Entity = new Dal.Class();
            Entity.Code = classDto.Code;
            Entity.Grade = classDto.Grade;
            Entity.NumClass = classDto.NumClass;
            return Entity;
        }
      
    }
}
