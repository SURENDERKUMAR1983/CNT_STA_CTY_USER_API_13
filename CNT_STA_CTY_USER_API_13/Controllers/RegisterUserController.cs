using CNT_STA_CTY_USER_API_13.data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNT_STA_CTY_USER_API_13.Controllers
{
    [Route("api/RegisterUser")]
    [ApiController]
    public class RegisterUserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RegisterUserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
        return Ok(_context.RegisterUsers.Include(x => x.City).Include(x => x.City.State).Include(x => x.City.State.Country).ToList());
        }
        [HttpGet("GetCountries")]
        public IActionResult GetAllCountries()
        {
            return Ok(_context.Countries.ToList());
        }
        [HttpGet]
        [Route("GetStates")]
        public IActionResult GetAllStatesByCountryId(int CountryId)
        {
            return Ok(_context.States.Where(x=>x.CountryId==CountryId).ToList());
        }
        [HttpGet]
        [Route("GetCities")]
        public IActionResult GetAllCitiesbyStateId(int StateId)
        {
            return Ok(_context.Cities.Where(x=>x.StateId==StateId).ToList());
        }
        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetAllUsersbyCityId(int CityId)
        {
            return Ok(_context.RegisterUsers.Include(x=>x.City).Include(x=>x.City.State).Include(x=>x.City.State.Country).Where(x=>x.CityId==CityId).ToList());
        }
        

        [HttpGet]
        [Route("GetAllUsersByCountry")]
        public IActionResult GetAllUsersByCountryId(int CountryId)
        {
          return Ok(_context.RegisterUsers.Include(x => x.City).Include(x =>x.City.State).Include(x => x.City.State.Country).Where(x => x.City.State.CountryId == CountryId).ToList());
        }
        [HttpGet]
        [Route("GetAllUsersByState")]
        public IActionResult GetAllUserByStateId(int StateId)
        {
          return Ok(_context.RegisterUsers.Include(x=> x.City).Include(x=>x.City.State).Include(x => x.City.State.Country).Where(x=> x.City.StateId==StateId).ToList());
        }       
        
    }
}
