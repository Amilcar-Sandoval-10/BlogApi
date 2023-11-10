using BlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Agregar los modelos aquí
        public DbSet<Contacto> Contacto { get; set; }

    }
}
