using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using ContosoUniversity.Persistencia.Data;
using ContosoUniversity.Persistencia.Repositorios;
using ContosoUniversity.Dominio.Models;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {

        private readonly IStudentRepository _repository;
        public Student Student { get; set; }
        public DeleteModel(IStudentRepository repository)
        {
            _repository = repository;
        }
        public void OnGet(int id)
        {
            Student = _repository.GetStudentByID(id);
        }
        public IActionResult OnPost(int id)
        {
            _repository.DeleteStudent(id);
            _repository.Save();
            return new RedirectToPageResult("./Index");
        }
    }
}
