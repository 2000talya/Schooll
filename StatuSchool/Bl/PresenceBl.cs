using System;
using System.Collections.Generic;
using Dto;

namespace Bl
{
    public class PresenceBl
    {
        public static List<presenceDTO> GetPresenceById(string id)
        {
            List<Dal.Presence> presences=Dal.PresenceDal.GetPresenceById(id);
            List<presenceDTO> p=new List<presenceDTO>();
            foreach (var presence in presences)
            {
                p.Add(Bl.Conversion.PresenceConverters.GetDTO(presence));
            }
            return p;
        }
    }
}