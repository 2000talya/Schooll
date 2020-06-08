using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Conversion
{
    public class PresenceConverters
    {
        ////DAL to DTO
        public static presenceDTO GetDTO(Dal.Presence presence)
        {
            presenceDTO dto = new presenceDTO();
            dto.Code = presence.Code;
            dto.StudentId = presence.StudentId;
            dto.Day = presence.Day;
            dto.Hour = presence.Hour;
            dto.Presence1 = presence.Presence1;
            return dto;
        }
        //DTO to DAL
        public static Dal.Presence GetEntity(presenceDTO presenceDto)
        {
            Dal.Presence Entity = new Dal.Presence();
            Entity.Code = presenceDto.Code;
            Entity.StudentId = presenceDto.StudentId;
            Entity.Day = presenceDto.Day;
            Entity.Hour = presenceDto.Hour;
            Entity.Presence1 = presenceDto.Presence1;
            return Entity;
        }

    }
}
