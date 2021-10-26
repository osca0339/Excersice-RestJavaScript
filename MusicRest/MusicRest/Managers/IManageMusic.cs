using MusicRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRest.Managers
{
    interface IManageMusic
    {
        IEnumerable<Music> Get(string filterBy, string Critiria);
        Music Get(int id);
        bool Create(Music value);
        bool Update(int id, Music value);
        Music Delete(int id);

    }
}
