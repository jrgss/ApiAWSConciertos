using ApiAWSConciertos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAWSConciertos.Data
{
    public class ConciertosContext:DbContext
    {
        public ConciertosContext(DbContextOptions<ConciertosContext> options) : base(options) { }
        public DbSet<CategoriaEvento> Categorias { get; set; }
        public DbSet<Evento> Eventos { get; set; }
    }
}
