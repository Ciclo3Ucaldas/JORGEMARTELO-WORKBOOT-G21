using System;
using System.Collections.Generic;
using System.Linq;
using TallerMintic.App.Dominio.Entidades;

namespace TallerMintic.App.Persistencia.AppRepositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly ApplicationContext _appContext;

        public RepositorioCliente(ApplicationContext context)
        {
            _appContext = context;
        }

        Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }
        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            var buscarCliente = _appContext.Clientes.FirstOrDefault(p => p.Id == idCliente);
            if (buscarCliente == null)
                return;
            _appContext.Clientes.Remove(buscarCliente);
            _appContext.SaveChanges();
        }
        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        {
            return _appContext.Clientes;
        }
        Cliente IRepositorioCliente.GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(p => p.Id == idCliente);
        }
        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
        {
            var buscarCliente = _appContext.Clientes.FirstOrDefault(p => p.Id == cliente.Id);
            if (buscarCliente != null)
            {
                buscarCliente.Nombre = cliente.Nombre;
                buscarCliente.Documento = cliente.Documento;
                buscarCliente.NumeroTelefonico = cliente.NumeroTelefonico;
                _appContext.SaveChanges();
            }
            return buscarCliente;

        }

    }
}