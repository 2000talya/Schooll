using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class taskDTO
    {
        public int Code { get; set; }
        public int SubjectCode { get; set; }
        public System.DateTime RequestDate { get; set; }
        public System.DateTime PresentDate { get; set; }
        public string Tiltle { get; set; }
        public string Description { get; set; }
        public string TeacherId { get; set; }
        public int ClassCode { get; set; }
    }
}
