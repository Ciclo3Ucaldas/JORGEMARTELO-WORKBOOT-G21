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
        private static void addCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = "Juan marin";
            cliente.Documento = "Cedula";
            cliente.NumeroTelefonico = 654;
            _repositorioCliente.addCliente(cliente);
        }

        private static void deleteCliente(int idCliente)
        {
            _repositorioCliente.deleteCliente(idCliente);
            Console.WriteLine("se Elimino el clitente" + idCliente);
        }

        private static void updateCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = "Juan marin";
            cliente.Documento = "Cedula";
            cliente.NumeroTelefonico = 654;
            _repositorioCliente.updateCliente(cliente);
            Console.WriteLine("se Actualizo correctamente el clitente");

        }
        private static void getAllCliente()
        {
            var clientes = _repositorioCliente.getAllCliente();
            Console.WriteLine("Lista de todos los clientes");

            foreach (var cliente in clientes)
            {
                Console.WriteLine("El Nombre es: " + cliente.Nombre);
                Console.WriteLine("El Documento es: " + cliente.Documento);
                Console.WriteLine("El Numero telefonico es: " + cliente.NumeroTelefonico);
                Console.WriteLine("");
            }
        }
        private static void getCliente()
        {
            var cliente = _repositorioCliente.getCliente();
            Console.WriteLine("Datos del cliente " + cliente.Nombre);
            Console.WriteLine("El Nombre es: " + cliente.Nombre);
            Console.WriteLine("El Documento es: " + cliente.Documento);
            Console.WriteLine("El Numero telefonico es: " + cliente.NumeroTelefonico);
            Console.WriteLine("");
        }
    }

}