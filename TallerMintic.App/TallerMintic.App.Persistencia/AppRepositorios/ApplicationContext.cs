using System;
using Microsoft.EntityFrameworkCore;
using TallerMintic.App.Dominio.Entidades;

namespace TallerMintic.App.Persistencia.AppRepositorios
{
    public class ApplicationContext : DbContext
    {

        private const string conexion = @"Data Source=localhost\sqlexpress;Initial Catalog=BbTallerMintic; Integrated Security=True;";
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // optionsBuilder.UseSqlServer("Data Source=(localdb)//MSSQLLocalDB Catalog=HopitalEncasa");
                optionsBuilder.UseSqlServer(conexion);
            }
        }
    }

}