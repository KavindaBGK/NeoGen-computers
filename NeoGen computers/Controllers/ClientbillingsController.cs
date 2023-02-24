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
    public class ClientbillingsController : ControllerBase
    {
        private readonly Computercontext _context;

        public ClientbillingsController(Computercontext context)
        {
            _context = context;
        }

        // GET: api/Clientbillings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientbilling>>> GetClientbillings()
        {
            return await _context.Clientbillings.ToListAsync();
        }

        // GET: api/Clientbillings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clientbilling>> GetClientbilling(int id)
        {
            var clientbilling = await _context.Clientbillings.FindAsync(id);

            if (clientbilling == null)
            {
                return NotFound();
            }

            return clientbilling;
        }

        // PUT: api/Clientbillings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientbilling(int id, Clientbilling clientbilling)
        {
            if (id != clientbilling.Billing_Number)
            {
                return BadRequest();
            }

            _context.Entry(clientbilling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientbillingExists(id))
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

        // POST: api/Clientbillings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Clientbilling>> PostClientbilling(Clientbilling clientbilling)
        {
            _context.Clientbillings.Add(clientbilling);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientbilling", new { id = clientbilling.Billing_Number }, clientbilling);
        }

        // DELETE: api/Clientbillings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientbilling(int id)
        {
            var clientbilling = await _context.Clientbillings.FindAsync(id);
            if (clientbilling == null)
            {
                return NotFound();
            }

            _context.Clientbillings.Remove(clientbilling);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientbillingExists(int id)
        {
            return _context.Clientbillings.Any(e => e.Billing_Number == id);
        }
    }
}
