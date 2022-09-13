using TallerMintic.App.Dominio.Entidades;
namespace TallerMintic.App.Persistencia.AppRepositorios
{
    public class Repositorio : IRepositorioGenerico<Cliente>
    {
        readonly ApplicationContext _context;
        public Repositorio(ApplicationContext context)
        {
            
            _context = context;
        }
/*
        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }
        public Cliente Get(int id)
        {
            return _resturantDb
            .Customers
                  .FirstOrDefault(e => e.ID == id);
        }

        public void Add(Cliente customer)
        {
            _resturantDb.Customers
            .Add(customer);
            _resturantDb.SaveChanges();
        }

        public void Change(Cliente customer, Cliente entity)
        {

            customer.Name = entity.Name;
            customer.Email = entity.Email;
            customer.Mobile = entity.Mobile;


            _resturantDb.SaveChanges();
        }

        public void Delete(Cliente customer)
        {
            _resturantDb.Customers.Remove(customer);
            _resturantDb.SaveChanges();
        }
*/    }
}