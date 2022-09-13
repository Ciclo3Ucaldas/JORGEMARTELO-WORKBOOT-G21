using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMintic.App.Persistencia.AppRepositorios;
using TallerMintic.App.Dominio.Entidades;

namespace MyApp.Namespace
{
    public class listModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente Clientes { get; set; }
        public listModel(IRepositorioCliente repositorio)
        {
            _repo = repositorio;
        }
        public void OnGet()
        {
           Clientes = _repo.GetCliente(2);
           Console.WriteLine("----------------------------");
          
           Console.WriteLine(Clientes.Nombre);
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine("");

        }
    }
}
