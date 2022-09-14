using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using ContosoUniversity.Persistencia.Data;
using ContosoUniversity.Persistencia.Repositorios;
using ContosoUniversity.Dominio.Models;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly IStudentRepository repositorio;
        public IEnumerable<Student> students { get; set; }
        public IndexModel(IStudentRepository repository)
        {
            this.repositorio = repository;
        }
        public void OnGet()
        {
            students.repositorio.GetStudents();
        }
    }
}
