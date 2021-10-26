using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRest.Models
{
    public class Music
    {
        private int _publicationYear;

        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear
        {
            get => _publicationYear;
            set
            {
                if(value > 2021)
                {
                    throw new ArgumentException();
                }
                _publicationYear = value;
            }
        }

        public Music(string title, string artist, int duration, int publicationYear)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }
    }
}
