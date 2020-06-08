using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class presenceDTO
    {
        public int Code { get; set; }
        public string StudentId { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public bool Presence1 { get; set; }
    }
}
