using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;
using PaymentAPI.Controllers;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;

namespace PaymentAPI.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<Payment> Payments {get; set;}
        //public virtual DbSet<RefreshToken> RefreshTokens {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            :base(options)
        {
            
        }
    }
}
