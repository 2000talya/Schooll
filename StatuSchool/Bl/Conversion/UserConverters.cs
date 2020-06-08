using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bl.Conversion
{
    public class UserConverters
    {
        //DAL to DTO
        public static userDTO GetDTO(Dal.User user)
        {
            userDTO dto = new userDTO();
            dto.Id = user.Id;
            dto.Email = user.Email;
            dto.FirstName = user.FirstName;
            dto.LastName = user.LastName;
            dto.Password = user.Password;
            return dto;
        }
        //DTO to DAL
        public static Dal.User GetEntity(userDTO userDto)
        {
            Dal.User Entity = new Dal.User();
            Entity.Id = userDto.Id;
            Entity.Email = userDto.Email;
            Entity.FirstName = userDto.FirstName;
            Entity.LastName = userDto.LastName;
            Entity.Password = userDto.Password;
            return Entity;
        }
    }
}
