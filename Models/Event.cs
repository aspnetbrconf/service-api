using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetBr.Api.Models
{
    public class Event
    {
        public Event()
        {
            this.Tracks = new List<Track>();
            this.Sponsors = new List<Sponsor>();
            this.Contacts = new List<Contact>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Edition { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Sponsor> Sponsors { get; set; }
        public Local Local { get; set; }
        public DateTime DueDate { get; set; }
        public List<Contact> Contacts { get; set; }
        public bool IsPrincipal { get; set; }
    }
}
