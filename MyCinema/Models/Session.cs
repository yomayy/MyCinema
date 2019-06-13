using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Begin { get; set; }
        public string End { get; set; }
        public int ScheduleId { get; set; }
        public int Price { get; set; }
    }
}
