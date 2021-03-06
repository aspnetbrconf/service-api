using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using AspnetBr.Api.Models;

namespace AspnetBr.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class EventsController : Controller
    {
        private AspnetBrContext _context;

        public EventsController(AspnetBrContext context){
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events
              .Include(e => e.Contacts)
              .Include(e => e.Local)
              .Include(e => e.Tracks)
              .Include(e => e.Sponsors)
              .ToList();
        }
    }
}
