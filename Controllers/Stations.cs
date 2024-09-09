using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketPricing2.models;

namespace TicketPricing2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Stations : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Stations(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var stations = await _context.Stations.ToListAsync();
            return Ok(stations);
        }
    }
}
