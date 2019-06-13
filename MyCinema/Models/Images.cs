using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema.Models
{
    public class Images
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int FilmId { get; set; }
    }
}
