using System;
using Microsoft.EntityFrameworkCore;
using TallerMintic.App.Dominio.Entidades;

namespace TallerMintic.App.Persistencia.AppRepositorios
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        
        /*private const string connectionString = @"Data Source=localhost;Initial Catalog=BbTallerMintic; Integrated Security=True;";

        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // optionsBuilder.UseSqlServer("Data Source=(localdb)//MSSQLLocalDB Catalog=HopitalEncasa");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        */
    }

}