using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
