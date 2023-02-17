using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cellar.Models
{
  public class CellarContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Wine> Wines { get; set; }
    public CellarContext(DbContextOptions options) : base(options) { }
  
  }
}