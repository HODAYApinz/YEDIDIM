using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesOfCallController : Controller
    {
        private static new List<TypesOfCall> typesofcalls = new List<TypesOfCall> {
                new TypesOfCall{Discribition="pancher",Id=1 },
                new TypesOfCall{Discribition="engine",Id =2}
            };
        // GET: TypesOfCallController
        [HttpGet]

        public IEnumerable<TypesOfCall> Get()
        {
            return typesofcalls;
        }
        [HttpGet("{id}")]

        // GET: TypesOfCallController/Details/5
        public TypesOfCall Get(int id)
        {
            int index = typesofcalls.FindIndex(e => e.Id == id);
            return typesofcalls[index];
        }

        // POST: TypesOfCallController/Create
        [HttpPost]
        public TypesOfCall Post([FromBody] TypesOfCall value)
        {
            typesofcalls.Add(value);
            return value;
        }
        // PUT api/<TypesOfCallController>/5
        [HttpPut("{id}")]
        public TypesOfCall Put(int id, [FromBody] TypesOfCall value)
        {
            int index = typesofcalls.FindIndex(e => e.Id == id);
            typesofcalls[index].Discribition = value.Discribition;
            return typesofcalls[index];
        }
        // DELETE api/<TypesOfCallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = typesofcalls.FindIndex(e => e.Id == id);
            volunteers.Remove(typesofcalls[index]);
        }
    }
}

