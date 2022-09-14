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
       // public Student students { get; set; }
        public CreateModel(IStudentRepository repository)
        {
            this._repositorio = repository;
        }
        public void OnGet()
        {
        /*    Console.WriteLine("Agregando 1");
            Student estudiante = new Student();
            estudiante.LasName = "Karla";
            estudiante.FirstMidName = "Gonzales";
            estudiante.EnrollmentDate = DateTime.Parse("2022-09-15");
            _repositorio.InsertStudent(estudiante);
            _repositorio.Save();
            Console.WriteLine("Exitoso");
            
            Console.WriteLine("Agregando 2");
            Student estudiante2 = new Student();
            estudiante2.LasName = "Maria";
            estudiante2.FirstMidName = "Gutierrez";
            estudiante2.EnrollmentDate = DateTime.Parse("2022-09-14");
            _repositorio.InsertStudent(estudiante2);
            _repositorio.Save();
            Console.WriteLine("Exitoso");
            
            Console.WriteLine("Agregando 3");
            Student estudiante3 = new Student();
            estudiante3.LasName = "Juan";
            estudiante3.FirstMidName = "Gonzales";
            estudiante3.EnrollmentDate = DateTime.Parse("2022-09-15");
            _repositorio.InsertStudent(estudiante3);
            _repositorio.Save();
            Console.WriteLine("Exitoso");
            
            Console.WriteLine("Agregando 4");
            Student estudiante4 = new Student();
            estudiante4.LasName = "Alfredo";
            estudiante4.FirstMidName = "Martinez";
            estudiante4.EnrollmentDate = DateTime.Parse("2022-09-15");
            _repositorio.InsertStudent(estudiante4);
            _repositorio.Save();
            Console.WriteLine("Exitoso");
       */ }

    }
}
