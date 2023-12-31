﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AguaMariaSolution.Server.DAL;
using AguaMariaSolution.Shared.Models;
using AguaMariaSolution.Client.Pages.Registros;

namespace AguaMariaSolution.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrosController : ControllerBase
    {
        private readonly Contexto _context;

        public ParametrosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Parametros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parametros>>> GetParametros()
        {
          if (_context.Parametros == null)
          {
              return NotFound();
          }
            return await _context.Parametros.ToListAsync();
        }

        // GET: api/Parametros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Parametros>> GetParametros(int id)
        {
          if (_context.Parametros == null)
          {
              return NotFound();
          }
            var parametros = await _context.Parametros.FindAsync(id);

            if (parametros == null)
            {
                return NotFound();
            }

            return parametros;
        }

        // PUT: api/Parametros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParametros(int id, Parametros parametros)
        {
            if (id != parametros.ParametroId)
            {
                return BadRequest();
            }

            _context.Entry(parametros).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParametrosExists(id))
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

        // POST: api/Parametros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Parametros>> PostParametros(Parametros parametros)
        {
            if (!ParametrosExists(parametros.ParametroId))
                _context.Parametros.Add(parametros);
            else
                _context.Parametros.Update(parametros);

            await _context.SaveChangesAsync();
            return Ok(parametros);
        }

        // DELETE: api/Parametros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParametros(int id)
        {
            if (_context.Parametros == null)
            {
                return NotFound();
            }
            var parametros = await _context.Parametros.FindAsync(id);
            if (parametros == null)
            {
                return NotFound();
            }

            _context.Parametros.Remove(parametros);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParametrosExists(int id)
        {
            return (_context.Parametros?.Any(e => e.ParametroId == id)).GetValueOrDefault();
        }
    }
}
