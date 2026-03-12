using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalAPI.Data;
using HospitalAPI.models;
using HospitalAPI.DTOs;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MedicinsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Medicins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicin>>> GetMedicins()
        {
            return await _context.Medicins.ToListAsync();
        }

        // GET: api/Medicins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medicin>> GetMedicin(int id)
        {
            var medicin = await _context.Medicins.FindAsync(id);

            if (medicin == null)
            {
                return NotFound();
            }

            return medicin;
        }

        // PUT: api/Medicins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicin(int id, Medicin medicin)
        {
            if (id != medicin.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicinExists(id))
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

        // POST: api/Medicins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostMedicin(MedicinDto medicin)
        {
            var med=new Medicin()
            {

                DrugName = medicin.DrugName,
                Stock=medicin.Stock,
            };
            _context.Medicins.Add(med);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicin", new { id = medicin.DrugName }, medicin);
        }

        // DELETE: api/Medicins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicin(int id)
        {
            var medicin = await _context.Medicins.FindAsync(id);
            if (medicin == null)
            {
                return NotFound();
            }

            _context.Medicins.Remove(medicin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicinExists(int id)
        {
            return _context.Medicins.Any(e => e.Id == id);
        }
    }
}
