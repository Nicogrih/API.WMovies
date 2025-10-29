using API.WMovies.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace API.WMovies.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        //Seccion para crear Dbset de las entidades o modelos
        public DbSet<Category> Categories { get; set; }
    }
}
