using System;
using System.Collections.Generic;
using Dto;
namespace Bl
{
    public class MarkBl
    {
        public static List<marksDTO> GetMarksById(string id)
        {
            List<Dal.Mark> marks = Dal.MarksDal.GetMarksById(id);
            List<marksDTO> m = new List<marksDTO>();
            foreach (var mark in marks)
            {
                m.Add(Bl.Conversion.MarksConverters.GetDTO(mark));
            }
            return m;
        }
    }
}