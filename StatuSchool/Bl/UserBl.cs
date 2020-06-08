using System;
using Dto;
using Dal;
namespace Bl
{
    public class UserBl
    {
        public static bool Register(userDTO user)
        {
            Dal.User u = Bl.Conversion.UserConverters.GetEntity(user);
            return Dal.userDAL.Register(u);
        }

        public static userDTO Login(string id, string password)
        {
            Dal.User u = Dal.userDAL.Login(id, password);
            Dto.userDTO user = Bl.Conversion.UserConverters.GetDTO(u);
            return user;
        }
    }
}