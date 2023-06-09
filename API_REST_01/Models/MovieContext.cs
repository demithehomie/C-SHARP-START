using Microsoft.EntityFrameworkCore;

namespace API_REST_01.Models
{
    public class MovieContext : DbContext


    {

        public  MovieContext(DbContextOptions<MovieContext> options) : base(options) 
        { 
            
        }

        DbSet<Movie> Movies { get; set; } = null;
    }
}
