using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Dominio.Models
{
    public class Student
    {
        public int ID{get;set;}
        public string LasName{get;set;}
        public string FirstMidName{get;set;}
         public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}