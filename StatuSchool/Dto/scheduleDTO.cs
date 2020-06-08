using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class scheduleDTO
    {
        public int Code { get; set; }
        public int ClassCode { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public string Subject { get; set; }
        public string TeacherId { get; set; }
    }
}
