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
        private readonly IStudentRepository _repositorio;
        public IEnumerable<Student> students { get; set; }
        public IndexModel(IStudentRepository repository)
        {
            this._repositorio = repository;
        }
        public void OnGet()
        {
            students = _repositorio.GetStudents();
            foreach (var studiantes in students)
            {
                Console.WriteLine("Agregando datos"+studiantes.LasName);                
            }
                Console.WriteLine("Agregando datos");
                Console.WriteLine("Agregando datos");
        }
    }
}
