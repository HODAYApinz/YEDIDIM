using Microsoft.AspNetCore.Mvc;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallFromPeopleController : Controller
    {
        private static new List<CallFromPeople> callsFromPeople = new List<CallFromPeople> {
                new CallFromPeople{Id=1,Name="hadasa",Phone="035700620",IdTypesOfCall=1,IdVolunteer=1},
                new CallFromPeople{Id=2,Name="hodaya",Phone="094566434",IdTypesOfCall=1,IdVolunteer=1}
            };
        // GET: TCallFromPeopleController
        [HttpGet]

        public IEnumerable<CallFromPeople> Get()
        {
            return callsFromPeople;
        }
        [HttpGet("{id}")]

        // GET: CallFromPeopleController/Details/5
        public CallFromPeople Get(int id)
        {
            int index = callsFromPeople.FindIndex(e => e.Id == id);
            return callsFromPeople[index];
        }

        // POST: CallFromPeopleController/Create
        [HttpPost]
        public CallFromPeople Post([FromBody] CallFromPeople value)
        {
            callsFromPeople.Add(value);
            return value;
        }
        // PUT api/<CallFromPeopleController>/5
        [HttpPut("{id}")]
        public CallFromPeople Put(int id, [FromBody] CallFromPeople value)
        {
            int index = callsFromPeople.FindIndex(e => e.Id == id);
            callsFromPeople[index].Phone = value.Phone;
            callsFromPeople[index].IdTypesOfCall = value.IdTypesOfCall;
            callsFromPeople[index].IdVolunteer = value.IdVolunteer;

            return typesofcalls[index];
        }
        // DELETE api/<CallFromPeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = callsFromPeople.FindIndex(e => e.Id == id);
            volunteers.Remove(callsFromPeople[index]);
        }
    }
}
