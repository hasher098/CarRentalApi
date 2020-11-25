using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApi.Entities;

namespace CarRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarCopiesController : ControllerBase
    {
        private readonly CarRentDbContext _context;

        public CarCopiesController(CarRentDbContext context)
        {
            _context = context;
        }

        // GET: api/CarCopies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarCopy>>> GetCarCopies()
        {
            return await _context.CarCopies.ToListAsync();
        }

        // GET: api/CarCopies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarCopy>> GetCarCopy(int id)
        {
            var carCopy = await _context.CarCopies.FindAsync(id);

            if (carCopy == null)
            {
                return NotFound();
            }

            return carCopy;
        }

        // PUT: api/CarCopies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarCopy(int id, CarCopy carCopy)
        {
            if (id != carCopy.Id)
            {
                return BadRequest();
            }

            _context.Entry(carCopy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarCopyExists(id))
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

        // POST: api/CarCopies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CarCopy>> PostCarCopy(CarCopy carCopy)
        {
            _context.CarCopies.Add(carCopy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarCopy", new { id = carCopy.Id }, carCopy);
        }

        // DELETE: api/CarCopies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CarCopy>> DeleteCarCopy(int id)
        {
            var carCopy = await _context.CarCopies.FindAsync(id);
            if (carCopy == null)
            {
                return NotFound();
            }

            _context.CarCopies.Remove(carCopy);
            await _context.SaveChangesAsync();

            return carCopy;
        }

        private bool CarCopyExists(int id)
        {
            return _context.CarCopies.Any(e => e.Id == id);
        }
        // GET: api/ChoosenCarCopies/1
        [Route("GetListOfCarCopies/{copyId}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarCopy>>> GetListOfCarCopies(int copyId)
        {
            var cars = from t in _context.CarCopies select t;
            cars = cars.Where(s => s.CarId == copyId);
            return await cars.ToListAsync();
        }
    }
}
