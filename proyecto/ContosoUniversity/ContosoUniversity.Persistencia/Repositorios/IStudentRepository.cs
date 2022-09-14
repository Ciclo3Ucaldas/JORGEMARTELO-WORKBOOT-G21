using System;
using System.Collections.Generic;
using ContosoUniversity.Dominio.Models;

namespace ContosoUniversity.Persistencia.Repositorios
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(int studentId);
        void InsertStudent(Student student);
        void DeleteStudent(int studentID);
        void UpdateStudent(Student student);
        void Save();
    }
}