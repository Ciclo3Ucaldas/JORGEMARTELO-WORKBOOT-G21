using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TallerMintic.App.Dominio.Entidades;
using TallerMintic.App.Persistencia.AppRepositorios;

namespace TallerMintic.App.Consola
{

    public class Program
    {
        private static IRepositorioCliente _repositorioCliente = new RepositorioCliente(new ApplicationContext());

        public static void Main(string[] args)
        {
            addClienteCosola();
        }
        private static void addClienteCosola()
        {
            var cliente = new Cliente
            {
                Nombre = "Jorge Martelo",
                Documento = "Cedula",
                NumeroTelefonico = 32
            };
        }
        private static void deleteClienteCosola()
        {
            var cliente = new Cliente
            {
                Nombre = "Jorge Martelo",
                Documento = "Cedula",
                NumeroTelefonico = 32
            };
        }

    }

}