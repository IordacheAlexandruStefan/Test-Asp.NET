using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Test_Asp.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdaugareParticipant : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdaugareParticipant(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost(Name = "AdaugareParticipant")]
        public async Task<IActionResult> AddWithFromForm([FromForm] Participant participant)
        {
            await participant.AddToDatabase(_context);

            return Ok(participant);
        }
    }
}