using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMintic.App.Dominio.Entidades;

namespace TallerMintic.App.Persistencia.AppRepositorios
{
    public class ApplicationContext:DbContext
    {
     public DbSet<Cliente> Clientes{get;set;}  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)//MSSQLLocalDB Catalog=HopitalEncasa");
            }
        } 
    }

}