using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRest.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public Music(int id, string title, string artist, int duration, int publicationYear)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }
    }
}
