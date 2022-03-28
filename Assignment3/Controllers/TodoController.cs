using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment3.Data;
using Microsoft.AspNetCore.Http;
using Assignment3.Models;



namespace Assignment3.Controllers 
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
       private readonly ApiDbContext _context;

        // [Route("TestRun")]
        // [HttpGet]

        // public ActionResult TestRrun()
        // {
        //     return Ok("Berhasil Memulai Test API");
        // }
        

        public TodoController(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }
        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemData data)
        {
            if(ModelState.IsValid)
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.Id}, data);
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
            if(item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if(id != item.Id)
                return BadRequest();
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return NotFound();

            existItem.Name = item.Name;
            existItem.Genre = item.Genre;
            existItem.Duration = item.Duration;
            existItem.ReleaseDate = item.ReleaseDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);

            if(existItem == null)
                return NotFound();

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}