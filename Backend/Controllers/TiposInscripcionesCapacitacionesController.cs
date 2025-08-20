﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DataContext;
using Service.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposInscripcionesCapacitacionesController : ControllerBase
    {
        private readonly AgoraContext _context;

        public TiposInscripcionesCapacitacionesController(AgoraContext context)
        {
            _context = context;
        }

        // GET: api/TiposInscripcionesCapacitaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoInscripcionCapacitacion>>> GetTiposInscripcionesCapacitaciones()
        {
            return await _context.TiposInscripcionesCapacitaciones.Include(t => t.Capacitacion).Include(t => t.TipoInscripcion).ToListAsync();
        }

        // GET: api/TiposInscripcionesCapacitaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoInscripcionCapacitacion>> GetTipoInscripcionCapacitacion(int id)
        {
            var tipoInscripcionCapacitacion = await _context.TiposInscripcionesCapacitaciones.FindAsync(id);

            if (tipoInscripcionCapacitacion == null)
            {
                return NotFound();
            }

            return tipoInscripcionCapacitacion;
        }

        // PUT: api/TiposInscripcionesCapacitaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoInscripcionCapacitacion(int id, TipoInscripcionCapacitacion tipoInscripcionCapacitacion)
        {
            if (id != tipoInscripcionCapacitacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoInscripcionCapacitacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoInscripcionCapacitacionExists(id))
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

        // POST: api/TiposInscripcionesCapacitaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoInscripcionCapacitacion>> PostTipoInscripcionCapacitacion(TipoInscripcionCapacitacion tipoInscripcionCapacitacion)
        {
            _context.TiposInscripcionesCapacitaciones.Add(tipoInscripcionCapacitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoInscripcionCapacitacion", new { id = tipoInscripcionCapacitacion.Id }, tipoInscripcionCapacitacion);
        }

        // DELETE: api/TiposInscripcionesCapacitaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoInscripcionCapacitacion(int id)
        {
            var tipoInscripcionCapacitacion = await _context.TiposInscripcionesCapacitaciones.FindAsync(id);
            if (tipoInscripcionCapacitacion == null)
            {
                return NotFound();
            }

            _context.TiposInscripcionesCapacitaciones.Remove(tipoInscripcionCapacitacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoInscripcionCapacitacionExists(int id)
        {
            return _context.TiposInscripcionesCapacitaciones.Any(e => e.Id == id);
        }
    }
}
