using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMintic.App.Dominio.Entidades;
using TallerMintic.App.Persistencia.AppRepositorios;

namespace TallerMintic.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
      
        private readonly IRepositorioCliente repositorioCliente;
        public IEnumerable<Cliente> clientes { get; set; }
        public ListModel(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }
        public void OnGet()
        {
            clientes=repositorioCliente.GetAllClientes();
        }
    }
}
