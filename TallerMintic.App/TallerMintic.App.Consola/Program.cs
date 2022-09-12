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
            Console.WriteLine("Ejecutando");
            addCliente();

        }
        private static void addCliente()
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = "Juan marin";
            cliente.Documento = "Cedula";
            cliente.NumeroTelefonico = 654;
            _repositorioCliente.AddCliente(cliente);
        }

        private static void deleteCliente(int idCliente)
        {
            _repositorioCliente.DeleteCliente(idCliente);
            Console.WriteLine("se Elimino el clitente" + idCliente);
        }

        private static void getAllCliente()
        {
            var clientes = _repositorioCliente.GetAllClientes();
            Console.WriteLine("Lista de todos los clientes");

            foreach (var cliente in clientes)
            {
                Console.WriteLine("El Nombre es: " + cliente.Nombre);
                Console.WriteLine("El Documento es: " + cliente.Documento);
                Console.WriteLine("El Numero telefonico es: " + cliente.NumeroTelefonico);
                Console.WriteLine("");
            }
        }
        private static void getCliente(int idCliente)
        {
            var cliente = _repositorioC   Console.WriteLine("");
            }
        }liente.GetCliente(idCliente);
            Console.WriteLine("Datos del cliente " + cliente.Nombre);
            Console.WriteLine("El Nombre es: " + cliente.Nombre);
            Console.WriteLine("El Documento es: " + cliente.Documento);
            Console.WriteLine("El Numero telefonico es: " + cliente.NumeroTelefonico);
            Console.WriteLine("");
        }
    }

}