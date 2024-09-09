using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketPricing2.models;

namespace TicketPricing2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsLine : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StationsLine(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetTicketPrice()
        {
            Console.WriteLine("enter the strart station:");
            string s = Console.ReadLine();
            Console.WriteLine("enter the end station :");
            string e = Console.ReadLine();
            int pos1=0, pos2=0, x=0 , pos3=0,pos4=0;
            var stationsline = await _context.StationsLine.ToListAsync();
            
            for (int i=0; i < stationsline.Count; i++)
            {
                if (stationsline[i].Name == s && stationsline[i].StationId == 1)
                {
                    pos1 = i;
                }
                if (stationsline[i].Name == e && stationsline[i].StationId == 1)
                {
                    pos2 = i;

                }
                x = pos2 - pos1;
                if (stationsline[i].istransition == true)
                {
                    pos3 = i;
                    if (stationsline[i].Name == e && stationsline[i].StationId == 2)
                    {
                        pos4 = i;
                        x = (pos4 - pos3) + (pos3 - pos1);
                    }
                }
                 
            }
            
            int price=0;
            if (x <= 9)
            {
                price = 10;
            }
            if(x<=16 && x > 9)
            {
                price = 15;
            }
            if (x > 16)
            {
                price = 20;
            }
            return Ok(price);
        }


    }
}
