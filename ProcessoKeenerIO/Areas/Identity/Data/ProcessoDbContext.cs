using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProcessoKeenerIO.Areas.Identity.Data;
using ProcessoKeenerIO.Models;

namespace ProcessoKeenerIO.Data
{
    public class ProcessoDbContext : IdentityDbContext<ApplicationUser>
    {
        public ProcessoDbContext(DbContextOptions<ProcessoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
