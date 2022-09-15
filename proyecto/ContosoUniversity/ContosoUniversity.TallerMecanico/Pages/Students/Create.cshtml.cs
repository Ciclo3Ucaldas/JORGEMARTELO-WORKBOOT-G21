using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using ContosoUniversity.Persistencia.Data;
using ContosoUniversity.Persistencia.Repositorios;
using ContosoUniversity.Dominio.Models;
namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly IStudentRepository _repositorio;
        public Student Student { get; set; }
        public CreateModel(IStudentRepository repository)
        {
            this._repositorio = repository;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Student student)
        {
            _repositorio.InsertStudent(student);
            return new RedirectToPageResult("./Index");
        }
    }
}
