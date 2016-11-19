using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebAPIApplication.Models;

namespace WebAPIApplication.Controllers
{
    public class EventControllers : Controller
    {
        
        private AppDBContext db;
        public EventControllers(AppDBContext context){
            db = context;
        }
        //POST api/user/event
        [Route("api/user/event")]
        [HttpPost]
        public void Post(Event value)
        {
            db.Event.Add(value);
            db.SaveChangesAsync();
        }
        //Delete api/user/event/{id}
        [Route("api/user/event")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Event event0 = db.Event.Find(id);
            db.Event.Remove(event0);

            db.SaveChangesAsync();
        }
        //Get api/schedule/event/{id}
        [Route("api/schedule/event")]
        [HttpGet]
        public IEnumerable<Event> Get(Event value)
        {
            IEnumerable<Event> events = db.Event;

            return events;
        }
    }
}