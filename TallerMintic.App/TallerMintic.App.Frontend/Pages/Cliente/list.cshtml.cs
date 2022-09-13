using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMintic.App.Persistencia.AppRepositorios;
using TallerMintic.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    public class listModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public IEnumerable<Cliente> Clientes { get; set; }
        public listModel(IRepositorioCliente repositorio)
        {
            _repo = repositorio;
        }
        public void OnGet()
        {
           Clientes = _repo.GetAllCliente();
        }
    }
}
