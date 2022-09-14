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
            Console.WriteLine("Lista de estudiantes");
            if (students != null)
            {
                foreach (var studiantes in students)
                {

                    Console.WriteLine("Nombre" + studiantes.LasName);
                    Console.WriteLine("Apellido" + studiantes.FirstMidName);
                    Console.WriteLine("Nombre" + studiantes.EnrollmentDate);

                }

            }
            Console.WriteLine("Agregando datos");
        }
    }
}
