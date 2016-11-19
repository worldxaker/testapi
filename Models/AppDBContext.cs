using Microsoft.EntityFrameworkCore;

namespace WebAPIApplication.Models
{
    public class AppDBContext:DbContext
    {
        public DbSet<Event> Event {get;set;}
        public DbSet<Geo> Geo {get;set;}
        //public DbSet<Repeat> Repeat {get;set;}
        public DbSet<User> User {get;set;}

        public AppDBContext(DbContextOptions<AppDBContext> options) 
            :base(options){

        }
    }
}