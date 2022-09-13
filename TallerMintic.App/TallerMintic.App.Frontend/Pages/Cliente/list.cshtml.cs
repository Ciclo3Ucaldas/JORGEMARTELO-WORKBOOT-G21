using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMintic.App.Persistencia.AppRepositorios;
using TallerMintic.App.Dominio.Entidades;
namespace MyApp.Namespace
{
    public class listModel : PageModel
    {
        private readonly ApplicationContext _contexto;
        public IEnumerable<Cliente> clientes { get; set; }

        public listModel(ApplicationContext application)
        {
            _contexto = application;
        }
        public void OnGet()
        {
//            clientes = _contexto.GetAllClientes();
        }


        /*    private readonly IRepositorioCliente _repo;
                public IEnumerable<Clientes> clientes { get; set; }
            public listModel(IRepositorioCliente repositorio)
            {
                _repo = repositorio;
            }
            public void OnGet()
            {

                clientes = _repo.Get
            }
       */
    }
}
