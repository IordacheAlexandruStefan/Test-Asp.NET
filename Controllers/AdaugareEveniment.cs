using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Test_Asp.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdaugareEveniment : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdaugareEveniment(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost(Name = "AdaugareEveniment")]
        public async Task<IActionResult> AddWithFromForm([FromForm] Eveniment eveniment)
        {
            await eveniment.AddToDatabase(_context);

            return Ok(eveniment);
        }
    }
}