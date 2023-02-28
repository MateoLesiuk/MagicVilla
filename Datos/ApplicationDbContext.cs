using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }   
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options) { }   

        protected override void OnModelCreating(ModelBuilder moderBuilder) {

            moderBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle= "Hermosa Villa con Vista al Lago",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=5,
                    Tarifa=200,
                    Amenidad="Pileta y Guardia",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion= DateTime.Now
                },
                                new Villa()
                                {
                                    Id = 2,
                                    Nombre = "Villa Rosada",
                                    Detalle = "Señoral y Placentera",
                                    ImagenUrl = "",
                                    Ocupantes = 5,
                                    MetrosCuadrados = 5,
                                    Tarifa = 500,
                                    Amenidad = "Restaurante bar, Equitación",
                                    FechaCreacion = DateTime.Now,
                                    FechaActualizacion = DateTime.Now
                                }
                );
            ;
        }
    }
}
