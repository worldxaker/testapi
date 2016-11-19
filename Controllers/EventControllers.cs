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
        //POST api/caretaker/event
        [Route("api/caretaker/event")]
        [HttpPost]
        public void Post(Event value)
        {
            db.Event.Add(value);
            db.SaveChangesAsync();
        }
        //Put api/caretaker/event
        [Route("api/caretaker/event")]
        [HttpPut]
        public Event Put(Event value){
            db.Event.Update(value);
            db.SaveChangesAsync();
            return value;
        }

        //Delete api/caretaker/event/{id}
        [Route("api/caretaker/event/{id}")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Event event0 = db.Event.Find(id);
            db.Event.Remove(event0);

            db.SaveChangesAsync();
        }
        //Get api/schedule/event
        [Route("api/schedule/event")]
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            IEnumerable<Event> events = db.Event;

            return events;
        }
    }
}