using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : Controller
    {
        private static new List<Volunteer> volunteers = new List<Volunteer> {
                new Volunteer{Id = 1, Name ="yonatan",Phone="0548449206",Pwd=1234} ,
                new Volunteer{Id = 2, Name ="yair",Phone ="0556786543",Pwd=223344}
            };
        // GET: VolunteerController
        [HttpGet]

        public IEnumerable<Volunteer> Get()
        {
            return volunteers;
        }

        // GET: VolunteerController/Details/5
        [HttpGet("{id}")]

        public Volunteer Get(int id)
        {
            int index = volunteers.FindIndex(e => e.Id == id);
            return volunteers[index];
        }

        // POST api/<VolunteerController>
        [HttpPost]
        public Volunteer Post([FromBody] Volunteer value)
        {
            volunteers.Add(value);
            return value;
        }

        // PUT api/<VolunteerController>/5
        [HttpPut("{id}")]
        public Volunteer Put(int id, [FromBody] Volunteer value)
        {
            int index = events.FindIndex(e => e.Id == id);
            volunteers[index].Name = value.Name;
            volunteers[index].Pwd = value.Pwd;
            volunteers[index].Phone = value.Phone;
            return volunteers[index];
        }

        // DELETE api/<VolunteerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = volunteers.FindIndex(e => e.Id == id);
            volunteers.Remove(volunteers[index]);
        }
    }
}


