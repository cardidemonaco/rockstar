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
        private readonly DataModelDbContext _context;
        private readonly ILogger<RockstarsController> _logger;

        public RockstarsController(DataModelDbContext context, ILogger<RockstarsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Get all rockstars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Artist> Get()
        {
            return _context.Artists;
        }

        [HttpGet]
        [Route("rush")]
        public async Task<IEnumerable<Artist>> GetRush()
        {
            return await _context.Artists//.Include(x => x.ArtistMembers)
                                         //.ThenInclude(x => x.Person)
                                         .Where(x => x.ArtistName == "Rush")
                                         .ToListAsync();
        }

        [HttpGet]
        [Route("{artist}")]
        public async Task<IEnumerable<Artist>> Get(string artist = "Metallica")
        {
            return await _context.Artists.Where(x => x.ArtistName == artist)
                                         .Include(x => x.Albums).ThenInclude(x => x.Songs)
                                         .Select(x => x)
                                         .ToListAsync();
        }
    }
}
