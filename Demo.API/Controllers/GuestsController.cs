using Demo.API.Models;
using Microsoft.AspNetCore.Mvc;


namespace Demo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<GuestModel> guests = new()
        {
            new GuestModel{Id = 1,FirstName ="Yiğitcan", LastName = "Ölmez" },
            new GuestModel{Id = 2, FirstName ="Mert", LastName ="Ölmez"},
            new GuestModel{Id = 3, FirstName ="Mösyö", LastName = "Bobiko"}
    };
        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<GuestModel> Get()
        {
            return guests;
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public GuestModel Get(int id)
        {
            return guests.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] GuestModel model)
        {
            guests.Add(model);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GuestModel model)
        {
            guests.Remove(guests.FirstOrDefault(g => g.Id == id));
            guests.Add(model);

        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guests.Remove(guests.FirstOrDefault(p => p.Id == id));
        }
    }
}
