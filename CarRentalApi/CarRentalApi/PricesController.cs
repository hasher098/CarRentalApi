using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApi.Entities;

namespace CarRentalApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesController : ControllerBase
    {
        private readonly CarRentDbContext _context;

        public PricesController(CarRentDbContext context)
        {
            _context = context;
        }

        // GET: api/Prices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pricing>>> GetPrices()
        {
            return await _context.Prices.ToListAsync();
        }

        // GET: api/Prices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pricing>> GetPricing(int id)
        {
            var pricing = await _context.Prices.FindAsync(id);

            if (pricing == null)
            {
                return NotFound();
            }

            return pricing;
        }

        // PUT: api/Prices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPricing(int id, Pricing pricing)
        {
            if (id != pricing.Id)
            {
                return BadRequest();
            }

            _context.Entry(pricing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PricingExists(id))
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

        // POST: api/Prices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pricing>> PostPricing(Pricing pricing)
        {
            _context.Prices.Add(pricing);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPricing", new { id = pricing.Id }, pricing);
        }

        // DELETE: api/Prices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pricing>> DeletePricing(int id)
        {
            var pricing = await _context.Prices.FindAsync(id);
            if (pricing == null)
            {
                return NotFound();
            }

            _context.Prices.Remove(pricing);
            await _context.SaveChangesAsync();

            return pricing;
        }

        private bool PricingExists(int id)
        {
            return _context.Prices.Any(e => e.Id == id);
        }
    }
}
