using APIPelicula.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPelicula.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base (options)
        {

        }
        public DbSet <Categoria> Categoria { get; set; }
    }

}
