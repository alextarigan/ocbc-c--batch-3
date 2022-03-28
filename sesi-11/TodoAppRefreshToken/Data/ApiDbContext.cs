using Microsoft.EntityFrameworkCore;
using TodoAppRefreshToken.Models;
using TodoAppRefreshToken.Controllers;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;

namespace TodoAppRefreshToken.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items {get; set;}
        public virtual DbSet<RefreshToken> RefreshTokens {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            :base(options)
        {
            
        }
    }
}
