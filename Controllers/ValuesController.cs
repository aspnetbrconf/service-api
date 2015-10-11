using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetBr.Api.Models;
using Microsoft.AspNet.Mvc;

namespace AspnetBr.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Sponsor> Get()
        {
            using(var db = new AspnetBrContext()){

                return db.Sponsors.ToList();

            }


            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
