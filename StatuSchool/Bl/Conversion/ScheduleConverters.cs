using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Conversion
{
    public class ScheduleConverters
    {
        ////DAL to DTO
        public static scheduleDTO GetDTO(Dal.Schedule schedule)
        {
            scheduleDTO dto = new scheduleDTO();
            dto.Code = schedule.Code;
            dto.ClassCode = schedule.ClassCode;
            dto.Day = schedule.Day;
            dto.Hour = schedule.Hour;
            dto.Subject = schedule.Subject;
            dto.TeacherId = schedule.TeacherId;
            return dto;
        }
        //DTO to DAL
        public static Dal.Schedule GetEntity(scheduleDTO scheduleDto)
        {
            Dal.Schedule Entity = new Dal.Schedule();
            Entity.Code = scheduleDto.Code;
            Entity.ClassCode = scheduleDto.ClassCode;
            Entity.Day = scheduleDto.Day;
            Entity.Hour = scheduleDto.Hour;
            Entity.Subject = scheduleDto.Subject;
            Entity.TeacherId = scheduleDto.TeacherId;
            return Entity;
        }
    }
}
