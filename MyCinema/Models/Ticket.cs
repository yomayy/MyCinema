using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int SeatId { get; set; }
    }
}
