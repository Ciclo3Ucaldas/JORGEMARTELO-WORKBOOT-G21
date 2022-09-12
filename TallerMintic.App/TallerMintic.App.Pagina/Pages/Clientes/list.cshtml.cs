using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMintic.App.Persistencia.AppRepositorios;
using TallerMintic.App.Dominio.Entidades;

namespace MyApp.Namespace
{
    public class listModel : PageModel
    {
        // solo  para leer
        private readonly IRepositorioCliente repositorioCliente;
        public IEnumerable<Cliente> clientesVista { get; set; }
        public listModel(IRepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }
        public void OnGet()
        {
            clientesVista = repositorioCliente.GetAllClientes();
        }
    }
}
