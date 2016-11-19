using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebAPIApplication.Models;

namespace WebAPIApplication.Controllers
{
    public class GeoControllers : Controller
    {
        
        private AppDBContext db;
        public GeoControllers(AppDBContext context){
            db = context;
        }
        //POST api/word/geo
        [Route("api/user/geo")]
        [HttpPost]
        public void Post(Geo value)
        {
            db.Geo.Add(value);
            db.SaveChangesAsync();
        }
        //Get api/caretaker/wordgeo
        [Route("api/caretaker/wordgeo")]
        [HttpGet]
        public IEnumerable<Geo> Get()
        {
            IEnumerable<Geo> geo = db.Geo;

            return geo;
        }
    }
}