using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoUniversity.Dominio.Models;
using ContosoUniversity.Persistencia.Data;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private IStudentRepository studentRepository;
        public StudentController()
        {
            this.studentRepository = new StudentRepository(new SchoolContext());
        }
        public void OnGet()
        {
        }
    }
}
