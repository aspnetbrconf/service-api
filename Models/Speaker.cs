using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetBr.Api.Models
{
    public class Speaker
    {
      public int Id { get; set; }
        public string Fullname { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string PhotoUrl { get; set; }
    }
}
