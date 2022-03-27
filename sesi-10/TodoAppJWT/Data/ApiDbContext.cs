using Microsoft.EntityFrameworkCore;
using TodoAppJWT.Models;
using TodoAppJWT.Controllers;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;

namespace TodoAppJWT.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            :base(options)
        {
            
        }
    }
}
