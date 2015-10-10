using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetBr.Api.Models
{
    public class Track
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Room { get; set; }
        public DateTime Day { get; set; }
        public Schedule Schedule { get; set; }
    }
}
