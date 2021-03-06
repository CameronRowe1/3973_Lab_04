using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab_04.Data;
using Lab_04.Models;
using Microsoft.AspNetCore.Cors;
using lab_04.Models;

namespace lab_04.Controllers
{
    [EnableCors("lab_05Policy")]
    //[EnableCors("HealthPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class Cities1Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Cities1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City1>>> GetCities()
        {
          // return await _context.Cities.ToListAsync();

            var applicationDbContext = _context.Cities.Include(c => c.Province);
            var raw = await applicationDbContext.ToListAsync();
            var result = new List<City1>();
            foreach(var city in raw) {
                result.Add(new City1(city.CityId, city.CityName, city.Population, city.ProvinceCode, city.Province.ProvinceName));
            }
            return result;
        }

        // GET: api/Cities1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);

            if (city == null)
            {
                return NotFound();
            }

            return city;
        }

        // PUT: api/Cities1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, City city)
        {
            if (id != city.CityId)
            {
                return BadRequest();
            }

            _context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cities1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<City>> PostCity(City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCity", new { id = city.CityId }, city);
        }

        // DELETE: api/Cities1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.CityId == id);
        }
    }
}
