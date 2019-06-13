using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCinema.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DirectoryId { get; set; }
        public int GenerId { get; set; }
    }
}
