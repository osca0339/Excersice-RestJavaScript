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
            new Music("The Best", "Foo Fighters", 110, 2002)
        };

        public List<Music> Get()
        {
            return musicList;
        }

        public Music Get(string title)
        {
            return musicList.Find(f => f.Title == title);
        }

        public bool Create(Music Value)
        {
            musicList.Add(Value);
            return true;
        }

        public bool Update(int id, Music Value)
        {
            Music music = Get(id)
        }
    }
}

