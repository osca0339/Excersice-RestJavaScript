using MusicRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRest.Managers
{
    public class MusicManagerDB : IManageMusic
    {
        private readonly DataBaseContext _context;

        public MusicManagerDB(DataBaseContext context)
        {
            _context = context;
        }

        public bool Create(Music value)
        {
            try
            {
                _context.Musics.Add(value);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Music Delete(int id)
        {
            try
            {
                var musicToDelete = _context.Musics.Find(id);
                _context.Musics.Remove(musicToDelete);
                _context.SaveChanges();
                return musicToDelete;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<Music> Get(string filterBy, string criteria)
        {
            List<Music> musics = _context.Musics.ToList();

            if (filterBy != null)
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
            return _context.Musics.Find(id);
        }

        public bool Update(int id, Music value)
        {
            try
            {
                var musicToUpdate = _context.Musics.Find(id);
                musicToUpdate.Title = value.Title;
                musicToUpdate.Artist = value.Artist;
                musicToUpdate.Duration = value.Duration;
                musicToUpdate.PublicationYear = value.PublicationYear;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
