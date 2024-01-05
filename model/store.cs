using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using roomapi.model;


namespace roomapi.model
{
    public static class Store
    {
        public static List <Room> roomList = new List<Room> {
            new Room {Id=3, Name= "Night out with the boys", keycode = "goodtunes",  images = new List<string> { "jpg01", "jpg02", "jpg03"} },
            new Room {Id=4, Name= "Friday night with the girls", keycode = "kevinisadork",  images = new List<string> { "jpg10", "jpg20", "jpg30" }},
            new Room { Id = 2, Name = "Saturday Game Night", keycode = "gamenight123", images = new List<string> { "pic01", "pic02", "pic03" } },
new Room { Id = 3, Name = "Chill Sunday Vibes", keycode = "relaxingtime", images = new List<string> { "image1", "image2", "image3" } },
new Room { Id = 4, Name = "Study Group Session", keycode = "smarties", images = new List<string> { "study01", "study02", "study03" } },
new Room { Id = 5, Name = "Virtual Coffee Hangout", keycode = "coffeelovers", images = new List<string> { "coffee01", "coffee02", "coffee03" } },
new Room { Id = 6, Name = "Creative Writing Workshop", keycode = "wordsmiths", images = new List<string> { "write01", "write02", "write03" } },
new Room { Id = 7, Name = "Fitness Challenge Group", keycode = "fitfam", images = new List<string> { "fit01", "fit02", "fit03" } },
new Room { Id = 8, Name = "Tech Talk Tuesdays", keycode = "techiesunite", images = new List<string> { "tech01", "tech02", "tech03" } },
new Room { Id = 9, Name = "Artistic Expression Gathering", keycode = "artlovers", images = new List<string> { "art01", "art02", "art03" } },
new Room { Id = 10, Name = "Cooking Enthusiasts Club", keycode = "chefsinaction", images = new List<string> { "cook01", "cook02", "cook03" } },
new Room { Id = 11, Name = "Language Exchange Forum", keycode = "polyglot", images = new List<string> { "lang01", "lang02", "lang03" } }

        };
    }
}