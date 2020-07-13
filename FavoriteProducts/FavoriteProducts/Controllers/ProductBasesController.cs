using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FavoriteProducts.Models;

namespace FavoriteProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductBasesController : ControllerBase
    {
        private readonly ProductBaseContext _context;

        public ProductBasesController(ProductBaseContext context)
        {
            _context = context;
        }

        // GET: api/ProductBases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductBase>>> GetProductBases()
        {
            return await _context.ProductBases.ToListAsync();
        }

        // GET: api/ProductBases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductBase>> GetProductBase(int id)
        {
            var productBase = await _context.ProductBases.FindAsync(id);

            if (productBase == null)
            {
                return NotFound();
            }

            return productBase;
        }

        // PUT: api/ProductBases/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductBase(int id, ProductBase productBase)
        {
            if (id != productBase.PID)
            {
                return BadRequest();
            }

            _context.Entry(productBase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductBaseExists(id))
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

        // POST: api/ProductBases
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProductBase>> PostProductBase(ProductBase productBase)
        {
            _context.ProductBases.Add(productBase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductBase", new { id = productBase.PID }, productBase);
        }

        // DELETE: api/ProductBases/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductBase>> DeleteProductBase(int id)
        {
            var productBase = await _context.ProductBases.FindAsync(id);
            if (productBase == null)
            {
                return NotFound();
            }

            _context.ProductBases.Remove(productBase);
            await _context.SaveChangesAsync();

            return productBase;
        }

        private bool ProductBaseExists(int id)
        {
            return _context.ProductBases.Any(e => e.PID == id);
        }
    }
}
