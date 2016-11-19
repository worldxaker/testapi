namespace WebAPIApplication.Models
{
    public class Event
    {
        public int Id {get;set;}
        public string Message {get;set;}
        public string Cron {get;set;}

        public int Times {get;set;}
        public int Interval {get;set;}
    }
}