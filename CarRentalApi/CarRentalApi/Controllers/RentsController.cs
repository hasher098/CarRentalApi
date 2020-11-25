using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApi.Entities;
using CarRentalApi.Authentication;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace CarRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentsController : ControllerBase
    {
        private readonly CarRentDbContext _context;
        public RentsController(CarRentDbContext context)
        {
            _context = context;
        }

        // GET: api/Rents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rent>>> GetRents()
        {
            return await _context.Rents.ToListAsync();
        }

        // GET: api/Rents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rent>> GetRent(int id)
        {
            var rent = await _context.Rents.FindAsync(id);

            if (rent == null)
            {
                return NotFound();
            }

            return rent;
        }

        // PUT: api/Rents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRent(int id, Rent rent)
        {
            if (id != rent.Id)
            {
                return BadRequest();
            }
            _context.Entry(rent).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentExists(id))
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

        // POST: api/Rents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rent>> PostRent(Rent rent)
        {
            _context.Rents.Add(rent);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetRent", new { id = rent.Id }, rent);
        }
        // DELETE: api/Rents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rent>> DeleteRent(int id)
        {
            var rent = await _context.Rents.FindAsync(id);
            if (rent == null)
            {
                return NotFound();
            }
            _context.Rents.Remove(rent);
            await _context.SaveChangesAsync();
            return rent;
        }
        private bool RentExists(int id)
        {
            return _context.Rents.Any(e => e.Id == id);
        }
        [HttpPost,Route("RentCar")]
        public async Task<ActionResult<Rent>> NewRent(string userId, int carCopyId, DateTime RentDate, DateTime ReturnDate)
        {
            var rent = new Rent
            {
                UserID = userId,
                CarCopyId = carCopyId,
                RentDate = RentDate,
                ReturnDate = ReturnDate
            };
            _context.Rents.Add(rent);
            var isRented = await _context.CarCopies.FindAsync(carCopyId);
            var user = await _context.Users.FindAsync(userId);
            if (isRented.IsRented == true)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = "This vehicle is already rented" });
            }
            else
            {
                if (isRented.IsRented == false && ReturnDate > DateTime.Now)
                {
                    isRented.IsRented = true;
                    _context.CarCopies.Update(isRented);
                }
                var envVar = Environment.GetEnvironmentVariable("SendGridCarRent");
                var mailClient = new SendGridClient(envVar);
                var msg = new SendGridMessage()
                {
                    From = new EmailAddress("kajublu@gmail.com", "CarRent"),
                    Subject = "Potwierdzenie wynajmu",
                    HtmlContent = $"<h3>Dziękujemy za wynajęcie auta. Poniżej znajdują się szczegóły dot. Twojego wynajmu.</h3>" +
                    $"<br><strong>Imię: </strong> {user.FirstName}" +
                    $"<br><strong>Nazwisko: </strong> {user.LastName}" +
                    $"<br><strong>Zamieszkały: </strong>{user.Address}" +
                    $"<br><strong>Nr dowodu: </strong> {user.IDcardNumber}" +
                    $"<br><strong>Pesel: </strong> {user.Pesel}" +
                    $"<br><strong>Nr rej. wynajętego pojazdu: </strong> {isRented.RegistrationNumber}" +
                    $"<br><strong>Data wynajmu: </strong> {rent.RentDate}" +
                    $"<br><strong>Data zwrotu: </strong> {rent.ReturnDate}" +
                    $"<h4>Po wynajęte auto proszę zgłosić się na adres: ul. XYZ, 42-200 Częstochowa</h4>"
                };
                msg.AddTo(new EmailAddress(user.Email));
                await mailClient.SendEmailAsync(msg);
                await _context.SaveChangesAsync();
                return NoContent();
            }    
        }
    }
}
