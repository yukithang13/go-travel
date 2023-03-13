using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelNet.Context;
using TravelNet.Models;

namespace TravelNet.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class LocationsController : ControllerBase
    {
        public IConfiguration _configuration;
        public readonly TravelDbContext _context;
        public LocationsController(IConfiguration configuration, TravelDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        [HttpGet]
        public async Task<User> Test(string username, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }
    }
}
