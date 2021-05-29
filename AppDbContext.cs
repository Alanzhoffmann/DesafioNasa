using DesafioNasa.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DesafioNasa
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("app");
        }

        public DbSet<Item> Itens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>()
                .HasData(new Item("Caixa de fósforos"),
                new Item("Alimento concentrado"),
                new Item("20m corda nylon"),
                new Item("Paraquedas de seda"),
                new Item("Aparelho portátil de aquecimento"),
                new Item("2 pistolas calibre 45"),
                new Item("caixa de leite em pó"),
                new Item("2 tanques de oxigênio 50kg cada"),
                new Item("Mapa estelar da constelação lunar"),
                new Item("Bussola"),
                new Item("Bote salva vidas"),
                new Item("20 litros de água"),
                new Item("Sinais luminosos"),
                new Item("Kit primeiros socorros"),
                new Item("Transmissor receptor portátil acionado por luz solar")
                );
        }
    }
}
