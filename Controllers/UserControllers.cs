using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebAPIApplication.Models;

namespace WebAPIApplication.Controllers
{
    //[Route("api/user/[controller]")]
    public class UserControllers : Controller
    {
        private AppDBContext db;
        public UserControllers(AppDBContext context){
            db = context;
        }

        [Route("api/user/event")]
        [HttpPost]
        public void Post(Event value)
        {
            db.Event.Add(value);
            db.SaveChangesAsync();
        }

        [Route("api/user/event")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Event event0 = db.Event.Find(id);
            db.Event.Remove(event0);

            db.SaveChangesAsync();
        }

        [Route("api/user/event")]
        [HttpGet]
        public IEnumerable<Event> Get(Event value)
        {
            IEnumerable<Event> events = db.Event;

            return events;
        }
        
    }
}