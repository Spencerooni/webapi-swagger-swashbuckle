using System.Collections.Generic;
using WebApiApplication.Models;

namespace WebApiApplication
{
    public static class StaticStore
    {
        public static readonly List<Activity> Activities;
        public static readonly List<Athlete> Athletes;

        static StaticStore()
        {
            Activities = new List<Activity>()
            {
                new Activity {Id = 1, Name = "Really windy one!"},
                new Activity {Id = 2, Name = "Fast down the hill"},
                new Activity {Id = 3, Name = "Enjoyable spin in the sun"}
            };

            Athletes = new List<Athlete>()
            {
                new Athlete {Id = 1, Name = "David"},
                new Athlete {Id = 2, Name = "John"},
                new Athlete {Id = 3, Name = "Rachel"}
            };
        }
    }
}