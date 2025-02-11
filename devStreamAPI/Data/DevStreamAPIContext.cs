using devStreamAPI.Models;
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

        //Definir as tabelas do banco de dados
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        //Sobrescrever o metodo OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Jogo>().ToTable("Jogos");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
        }
        public DbSet<devStreamAPI.Models.Carrinho> Carrinho { get; set; } = default!;
        public DbSet<devStreamAPI.Models.ItemCarrinho> ItemCarrinho { get; set; } = default!;

    }
}
