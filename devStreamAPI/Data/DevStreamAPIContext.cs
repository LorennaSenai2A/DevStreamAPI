using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace devStreamAPI.Data
{
    public class DevStreamAPIContext : IdentityDbContext
    {
        //Metodo construtor 
        public DevStreamAPIContext(DbContextOptions<DevStreamAPIContext> options) : base(options)
        {
        }

        //Sobrescrever o metodo OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
