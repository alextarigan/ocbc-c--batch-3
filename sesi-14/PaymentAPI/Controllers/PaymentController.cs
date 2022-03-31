using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Data;
using Microsoft.AspNetCore.Http;
using PaymentAPI.Models;
using PaymentAPI.Models.DTOs.Requests;
using PaymentAPI.Models.DTOs.Responses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;



namespace PaymentAPI.Controllers 
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PaymentDetail : ControllerBase
    {
       private readonly ApiDbContext _context;

        // [Route("TestRun")]
        // [HttpGet]

        // public ActionResult TestRrun()
        // {
        //     return Ok("Berhasil Memulai Test API");
        // }
        

        public PaymentDetail(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetItem()
        {
            var payments = await _context.Payments.ToListAsync();
            return Ok(payments);
        }
        [HttpPost]
        public async Task<IActionResult> CreateItem(Payment data)
        {
            if(ModelState.IsValid)
            {
                await _context.Payments.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new {data.paymentDetailId}, data);
                
            }
            return new JsonResult("Something went wrong") {StatusCode = 500};
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var payment = await _context.Payments.FirstOrDefaultAsync(x => x.paymentDetailId == id);
            if(payment == null)
                return NotFound();
            return Ok(payment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, Payment payment)
        {
            if(id != payment.paymentDetailId)
                return BadRequest();
            var existItem = await _context.Payments.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(existItem == null)
                return NotFound();

            existItem.cardOwnerName = payment.cardOwnerName;
            existItem.cardNumber = payment.cardNumber;
            existItem.expirationDate = payment.expirationDate;
            existItem.securityCode = payment.securityCode;

            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Payments.FirstOrDefaultAsync(x => x.paymentDetailId == id);

            if(existItem == null)
                return NotFound();

            _context.Payments.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}