using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeCard.API.Model;
using TimeCard.API.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace TimeCard.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeCardController : ControllerBase
    {
        public readonly TimeCardContext _timeCardRepository;
        private readonly ILogger<TimeCardController> _logger;

        public TimeCardController(ILogger<TimeCardController> logger, TimeCardContext timeCardRepository)
        {
            _logger = logger;
            _timeCardRepository = timeCardRepository;
        }

        [HttpGet("getTimeCard/{id:int}")]
        [ProducesResponseType(typeof(TimeCards), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<TimeCards>> GetTimeCardByID(int ID)
        {
            return await GetTimeCardAsync(ID);
        }

        [HttpGet("byemployee/{employeeid:int}")]
        [ProducesResponseType(typeof(List<TimeCards>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<TimeCards>>> GetTimeCardsByEmployeeID(int employeeId)
        {
            return Ok(await GetTimeCardsByEmployee(employeeId));
        }

        [HttpPost("addnew")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public ActionResult<TimeCards> AddNew(int employeeID, string PunchType, string TimeCode)
        {
            var item = new TimeCards(employeeID);
            item.PunchType = PunchType;
            item.TimeCode = TimeCode;

            _timeCardRepository.TimeCard.Add(item);

            _timeCardRepository.SaveChanges();

            return Accepted();
        }

        [HttpDelete("delete/{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<TimeCards>> DeleteCard(int id)
        {
            var item = await _timeCardRepository.TimeCard.FindAsync(id);
            _timeCardRepository.Remove(item);
            _timeCardRepository.SaveChanges();

            return Ok();
        }


        private async Task<TimeCards> GetTimeCardAsync(int id)
        {
            return await _timeCardRepository.TimeCard.FindAsync(id);
             
        }

        private async Task<List<TimeCards>> GetTimeCardsByEmployee(int employeeID)
        {
            return await _timeCardRepository.TimeCard.Where(tc => tc.EmployeeID == employeeID).ToListAsync();
            
        }


    }
}
