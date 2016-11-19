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
        //POST api/user/geo
        [Route("api/user/geo")]
        [HttpPost]
        public void Post(Geo value)
        {
            db.Geo.Add(value);
            db.SaveChangesAsync();
        }
        //Delete api/user/geo/{id}
        [Route("api/user/geo/{id}")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Geo geo = db.Geo.Find(id);
            db.Geo.Remove(geo);

            db.SaveChangesAsync();
        }
        //Get api/schedule/geo
        [Route("api/schedule/geo")]
        [HttpGet]
        public IEnumerable<Geo> Get()
        {
            IEnumerable<Geo> geo = db.Geo;

            return geo;
        }
    }
}