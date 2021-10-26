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
            new Music(1, "My Heart Goes On", "Celine Dion", 100, 1999),
            new Music(2, "Bad", "Michael Jackson", 120, 1988),
            new Music(3, "The Best", "Foo Fighters", 120, 2002)
        };

        public List<Music> Get(string filterBy = null, string criteria = null)
        {
            List<Music> musics = musicList;

            if(filterBy != null)
            {
                switch (filterBy.ToLower())
                {
                    case "id":
                        musics = musics.FindAll(m => m.Id == Convert.ToInt32(criteria));
                        break;
                    case "title":
                        musics = musics.FindAll(m => m.Title == criteria);
                        break;
                    case "artist":
                        musics = musics.FindAll(m => m.Artist == criteria);
                        break;
                    case "duration":
                        musics = musics.FindAll(m => m.Duration == Convert.ToInt32(criteria));
                        break;
                    case "publicationyear":
                        musics = musics.FindAll(m => m.PublicationYear == Convert.ToInt32(criteria));
                        break;
                }
            }

            return musics;
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

