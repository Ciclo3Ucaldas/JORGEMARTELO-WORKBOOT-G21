using System;
using TallerMecanica.App.Dominio;
using TallerMecanica.App.Persistencia; 



namespace TallerMecanica.App.Consola
{
    class Program
    {

        private static InterfazRepositorioPersona _repositorioPersona = new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! entity framewok");
            AddPersona();
        }

        private static void AddPersona()
        {
         var persona = new Persona
   
            {
            Nombre = "Nicolay",
            
             };
        _repositorioPersona.AddPersona(persona);

        }
    }
}
