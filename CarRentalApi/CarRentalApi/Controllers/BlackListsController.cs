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
    public class BlackListsController : ControllerBase
    {
        private readonly CarRentDbContext _context;

        public BlackListsController(CarRentDbContext context)
        {
            _context = context;
        }

        // GET: api/BlackLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BlackList>>> GetBlackList()
        {
            return await _context.BlackList.ToListAsync();
        }

        // GET: api/BlackLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BlackList>> GetBlackList(int id)
        {
            var blackList = await _context.BlackList.FindAsync(id);

            if (blackList == null)
            {
                return NotFound();
            }

            return blackList;
        }

        // PUT: api/BlackLists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlackList(int id, BlackList blackList)
        {
            if (id != blackList.Id)
            {
                return BadRequest();
            }

            _context.Entry(blackList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlackListExists(id))
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

        // POST: api/BlackLists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BlackList>> PostBlackList(BlackList blackList)
        {
            _context.BlackList.Add(blackList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBlackList", new { id = blackList.Id }, blackList);
        }

        // DELETE: api/BlackLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BlackList>> DeleteBlackList(int id)
        {
            var blackList = await _context.BlackList.FindAsync(id);
            if (blackList == null)
            {
                return NotFound();
            }

            _context.BlackList.Remove(blackList);
            await _context.SaveChangesAsync();

            return blackList;
        }

        private bool BlackListExists(int id)
        {
            return _context.BlackList.Any(e => e.Id == id);
        }
    }
}
