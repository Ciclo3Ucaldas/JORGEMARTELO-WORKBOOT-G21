using Microsoft.EntityFrameworkCore;
using TallerMecanica.App.Dominio;

namespace TallerMecanica.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured) 
            {
              optionsBuilder
              .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TallerMecanicatData");
          
            }
        }
    
    }


}


    
