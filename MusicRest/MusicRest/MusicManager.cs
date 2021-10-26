using MusicRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRest
{
    public class MusicManager
    {
        private static List<Music> musicList = new List<Music>()
        {
            new Music("My Heart Goes On", "Celine Dion", 100, 1999),
            new Music("Bad", "Michael Jackson", 120, 1988),
            new Music("The Best", "Foo Fighters", 120, 2002)
        };

        public List<Music> Get()
        {
            return musicList;
        }

        public Music Get(string title)
        {
            return musicList.Find(m => m.Title == title);
        }

        public Music GetByArtist(string artist)
        {
            return musicList.Find(m => m.Artist == artist);
        }

        public List<Music> GetByDuration(int duration)
        {
            List<Music> musicByDuration = new List<Music>();
            foreach(Music m in musicList)
            {
                if(m.Duration == duration)
                {
                    musicByDuration.Add(m);
                }
            }
            return musicByDuration;
        }

        public bool Create(Music Value)
        {
            musicList.Add(Value);
            return true;
        }

        public bool Update(string title, Music value)
        {
            Music music = Get(title);
            if(music != null)
            {
                music.Title = value.Title;
                music.Artist = value.Artist;
                music.Duration = value.Duration;
                music.PublicationYear = value.PublicationYear;
                return true;
            }
            return false;
        }

        public Music Delete(string title)
        {
            Music musicToDelete = Get(title);
            musicList.Remove(musicToDelete);
            return musicToDelete;
        }
    }
}

