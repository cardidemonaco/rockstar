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
    public class RockstarController : ControllerBase
    {
        private readonly DataModelDbContext _context;
        private readonly ILogger<RockstarsController> _logger;

        public RockstarController(DataModelDbContext context, ILogger<RockstarsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Get all rockstars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _context.People;
        }

        [HttpGet]
        [Route("neil peart")]
        public async Task<IEnumerable<Person>> GetNeilPeart()
        {
            return await _context.People
                                 //.Include(x => x.PersonBands)
                                 .Where(x => x.PersonNameFirst == "Neil" && x.PersonNameLast == "Peart")
                                 .ToListAsync();
        }

        [HttpGet]
        [Route("{person}")]
        public IEnumerable<Person> Get(string person = "Travis Barker")
        {
            var people = _context.People.ToListAsync();
            return people.Result.Where(x => x.PersonNameFull == person).ToList();
        }
    }
}
