﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AguaMariaSolutionsDoNet8.Data;
using AguaMariaSolutionsDoNet8.Shared.Models;

namespace AguaMariaSolutionsDoNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdminsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Admins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admins>>> GetAdmins()
        {
          if (_context.Admins == null)
          {
              return NotFound();
          }
            return await _context.Admins.ToListAsync();
        }

        // GET: api/Admins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admins>> GetAdmins(int id)
        {
          if (_context.Admins == null)
          {
              return NotFound();
          }
            var admins = await _context.Admins.FindAsync(id);

            if (admins == null)
            {
                return NotFound();
            }

            return admins;
        }

        // PUT: api/Admins/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmins(int id, Admins admins)
        {
            if (id != admins.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(admins).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminsExists(id))
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

        // POST: api/Admins
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Admins>> PostAdmins(Admins admins)
        {
                if (!AdminsExists(admins.AdminId))
                    _context.Admins.Add(admins);
                else
                    _context.Admins.Update(admins);

                await _context.SaveChangesAsync();
                return Ok(admins);
        }

        // DELETE: api/Admins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmins(int id)
        {
            if (_context.Admins == null)
            {
                return NotFound();
            }
            var admins = await _context.Admins.FindAsync(id);
            if (admins == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(admins);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminsExists(int id)
        {
            return (_context.Admins?.Any(e => e.AdminId == id)).GetValueOrDefault();
        }
    }
}
