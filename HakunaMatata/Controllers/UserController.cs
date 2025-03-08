using Microsoft.AspNetCore.Mvc;
using HakunaMatata.Data;
using Microsoft.EntityFrameworkCore;

namespace HakunaMatata.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(UserDbContext context) : ControllerBase
    {
        private readonly UserDbContext _context = context;

        [HttpGet("get-sales-counter/{user_id}")]
        public async Task<ActionResult> GetSalesCounter(string user_id)
        {
            return Ok(await _context.Users.ToListAsync());
        }
    }
}
