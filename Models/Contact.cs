using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetBr.Api.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
    }
}
