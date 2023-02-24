using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeoGen_computers.Model;
using NeoGen_computers.Models;

namespace NeoGen_computers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersDetailsController : ControllerBase
    {
        private readonly Computercontext _context;

        public SellersDetailsController(Computercontext context)
        {
            _context = context;
        }

        // GET: api/SellersDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SellersDetails>>> GetSellersDetails()
        {
            return await _context.SellersDetails.ToListAsync();
        }

        // GET: api/SellersDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SellersDetails>> GetSellersDetails(int id)
        {
            var sellersDetails = await _context.SellersDetails.FindAsync(id);

            if (sellersDetails == null)
            {
                return NotFound();
            }

            return sellersDetails;
        }

        // PUT: api/SellersDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSellersDetails(int id, SellersDetails sellersDetails)
        {
            if (id != sellersDetails.Seller_Id)
            {
                return BadRequest();
            }

            _context.Entry(sellersDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SellersDetailsExists(id))
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

        // POST: api/SellersDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SellersDetails>> PostSellersDetails(SellersDetails sellersDetails)
        {
            _context.SellersDetails.Add(sellersDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSellersDetails", new { id = sellersDetails.Seller_Id }, sellersDetails);
        }

        // DELETE: api/SellersDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSellersDetails(int id)
        {
            var sellersDetails = await _context.SellersDetails.FindAsync(id);
            if (sellersDetails == null)
            {
                return NotFound();
            }

            _context.SellersDetails.Remove(sellersDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SellersDetailsExists(int id)
        {
            return _context.SellersDetails.Any(e => e.Seller_Id == id);
        }
    }
}
