using Microsoft.AspNetCore.Mvc;
using MusicRest.Managers;
using MusicRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        readonly IManageMusic manager = new MusicManager();
        // GET: api/<MusicController>
        [HttpGet]
        public IEnumerable<Music> Get(string filterBy, string criteria)
        {
            return manager.Get(filterBy, criteria);
        }

        // GET api/<MusicController>/5
        [HttpGet("{id}")]
        public Music Get(int id)
        {
            return manager.Get(id);
        }

        // POST api/<MusicController>
        [HttpPost]
        public bool Post([FromBody] Music value)
        {
            return manager.Create(value);
        }

        // PUT api/<MusicController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Music value)
        {
            return manager.Update(id, value);
        }

        // DELETE api/<MusicController>/5
        [HttpDelete("{id}")]
        public Music Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}
