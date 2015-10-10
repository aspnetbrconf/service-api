using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetBr.Api.Models
{
    public class Talk
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Speaker> Speakers { get; set; }
    }
}
