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

        public Music Get(int id)
        {
            return musicList.Find(m => m.Id == id);
        }

        public List<Music> GetTitle(string title)
        {
            return musicList.FindAll(m => m.Title == title);
        }

        public List<Music> GetByArtist(string artist)
        {
            List<Music> musicByArtist = new List<Music>();
            foreach(Music m in musicList)
            {
                if(m.Artist == artist)
                {
                    musicByArtist.Add(m);
                }
            }
            return musicByArtist;
            
        }

        public List<Music> GetByPublicationYear(int publicationYear)
        {
            List<Music> musicByPublationYear = new List<Music>();
            foreach(Music m in musicList)
            {
                if(m.PublicationYear == publicationYear)
                {
                    musicByPublationYear.Add(m);
                }
            }
            return musicByPublationYear;
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

        public bool Update(int id, Music value)
        {
            Music music = Get(id);
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

        public Music Delete(int id)
        {
            Music musicToDelete = Get(id);
            musicList.Remove(musicToDelete);
            return musicToDelete;
        }
    }
}

