using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int Place { get; set; }
        public bool Status { get; set; }
    }
}
