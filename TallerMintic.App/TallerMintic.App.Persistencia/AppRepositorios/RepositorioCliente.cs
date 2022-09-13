using System;
using System.Collections.Generic;
using System.Linq;
using TallerMintic.App.Dominio.Entidades;

namespace TallerMintic.App.Persistencia.AppRepositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly ApplicationContext _context;
        public RepositorioCliente(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        public RepositorioCliente() { }
        public Cliente AddCliente(Cliente cliente)
        {
            var clientsAdd = _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return clientsAdd.Entity;
        }
        public void DeleteCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAllCliente()
        {
            return _context.Clientes;
        }

        public Cliente GetCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}