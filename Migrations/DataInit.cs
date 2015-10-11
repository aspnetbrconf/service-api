using Microsoft.Data.Entity;
using AspnetBr.Api.Models;
using System.Linq;
using System;

namespace AspnetBr.Api.Migrations
{
    public class DataInit
    {
        private AspnetBrContext _context;

        public DataInit(AspnetBrContext ctx)
        {
            _context = ctx;
        }

        public void AddEvent()
        {
            if (!_context.Events.Any())
            {
                var evt = new Event
                {
                    Title = "ASP.NET Brasil Conferece",
                    Edition = "2015",
                    DueDate = new DateTime(2015, 5, 16)
                };

                AddLocal(evt);
                AddContacts(evt);
                AddSponsors(evt);

                _context.Events.Add(evt);

                _context.SaveChanges();
            }
        }

        public void AddLocal(Event evt)
        {
            if (!_context.Locals.Any())
            {
                var local = new Local
                {
                    Address = "Av. Lins de Vasconcelos, 1264, 8º andar",
                    Name = "Fiap",
                    MapsUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3656.829232075417!2d-46.623255!3d-23.5745759!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce597ac312a633%3A0xa80d7876ff1579b4!2sAv.+Lins+de+Vasconcelos%2C+1264+-+Cambuci%2C+S%C3%A3o+Paulo+-+SP%2C+01538-001!5e0!3m2!1spt-BR!2sbr!4v1424220779369"
                };

                evt.Local = local;

                _context.Locals.Add(local);
            }
        }

        private void AddContacts(Event evt)
        {
            if (!_context.Contacts.Any())
            {
                var email = new Contact
                {
                    Type = "email",
                    Text = "contato@aspnetbr.com"
                };

                var facebook = new Contact
                {
                    Type = "facebook",
                    Text = "https://www.facebook.com/AspNetBrasilConference"
                };

                evt.Contacts.Add(email);
                evt.Contacts.Add(facebook);

                _context.Contacts.Add(email);
                _context.Contacts.Add(facebook);
            }
        }

        private void AddSponsors(Event evt)
        {
            if (!_context.Sponsors.Any())
            {
                var fcamara = new Sponsor
                {
                    Name = "FCamara",
                    Level = "ouro"
                };

                var _2pc = new Sponsor
                {
                    Name = "2PC",
                    Level = "prata"
                };

                var lambda = new Sponsor
                {
                    Name = "Lambda3",
                    Level = "bronze"
                };

                evt.Sponsors.Add(fcamara);
                evt.Sponsors.Add(_2pc);
                evt.Sponsors.Add(lambda);

                _context.Sponsors.Add(fcamara);
                _context.Sponsors.Add(_2pc);
                _context.Sponsors.Add(lambda);
            }
        }
    }
}
