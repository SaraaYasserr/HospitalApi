using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAPI.Data;
using HospitalAPI.DTOs;
using HospitalAPI.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddMedicinsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AddMedicinsController(AppDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicin>>> GetMedicins()
        {
            return await _context.Medicins.ToListAsync();
        }

       
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

        
        [HttpPost]
        public async Task<IActionResult> PostMedicin(MedicinDto medicin)
        {
            var med = new Medicin()
            {

                DrugName = medicin.DrugName,
                Stock = medicin.Stock,
            };
            _context.Medicins.Add(med);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicin", new { id = medicin.DrugName }, medicin);
        }

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
