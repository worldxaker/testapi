using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebAPIApplication.Models;
namespace WebAPIApplication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private AppDBContext db;

        public ValuesController(AppDBContext context){
            db = context;
            Geo geo1 = new Geo{ isAlert=true, lang="dsrsdfdsjndsfsj" };
            db.Geo.Add(geo1);
            db.SaveChangesAsync();
        }

        // GET api/values
        [HttpGet]
        public Geo Get()
        {
            Geo geo0 = db.Geo.First();
            return geo0;
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
