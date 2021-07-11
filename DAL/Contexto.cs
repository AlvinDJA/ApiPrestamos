
using Microsoft.EntityFrameworkCore;
using ApiPrestamos.Models;

namespace ApiPrestamos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\ApiPrestamos.db");
        }

    }
}
