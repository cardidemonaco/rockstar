using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using rockstar.Data;
using rockstar.Data.Entities;

namespace rockstar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RockstarsController : ControllerBase
    {
        public readonly DataModelDbContext _context;
        private readonly ILogger<RockstarsController> _logger;

        public RockstarsController(DataModelDbContext context, ILogger<RockstarsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _context.People;
        }

        [HttpGet]
        [Route("[controller]/rush")]
        public async Task<IEnumerable<Person>> GetRush()
        {
            return await _context.PersonArtists.Include(x => x.Person)
                                  .Include(x => x.Artist)
                                  .Where(x => x.Artist.ArtistName == "Rush")
                                  .Select(x => x.Person).ToListAsync();
        }
    }
}
