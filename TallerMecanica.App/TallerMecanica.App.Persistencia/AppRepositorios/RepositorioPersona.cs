using System.Collections.Generic;
using TallerMecanica.App.Dominio;
using System.Linq;


namespace TallerMecanica.App.Persistencia
{


public class RepositorioPersona : InterfazRepositorioPersona

{
    // Referencia al contexto

    private readonly AppContext _appContext;

    public RepositorioPersona(AppContext appContext)
    
    {
        _appContext = appContext;

    }

        

       public Persona AddPersona (Persona persona)
    {
        var PersonaAdicionada = _appContext.Personas.Add(persona);
        _appContext.SaveChanges();
        return PersonaAdicionada.Entity;

    }

       

        void DeletePersona (int IdPersona)
    {

        var PersonaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id== IdPersona);
        if (PersonaEncontrada == null)
           return;
        _appContext.Personas.Remove(PersonaEncontrada);
         _appContext.SaveChanges();

    }

        void InterfazRepositorioPersona.DeletePersona(int IdPersona)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable <Persona> InterfazRepositorioPersona.GetAllPersona()
    {
        return _appContext.Personas;
    }

    Persona GetPersona (int IdPersona)
    {
       return _appContext.Personas.FirstOrDefault(p => p.Id== IdPersona);
    }

        Persona InterfazRepositorioPersona.GetPersona(int IdPersona)
        {
            throw new System.NotImplementedException();
        }

        Persona UpdatePersona (Persona persona)
    {
        var PersonaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id== persona.Id);
        if (PersonaEncontrada!=null)
        {
        PersonaEncontrada.Nombre = persona.Nombre;

        _appContext.SaveChanges();
       
        }
         return PersonaEncontrada;
    }

        Persona InterfazRepositorioPersona.UpdatePersona(Persona persona)
        {
            throw new System.NotImplementedException();
        }
    }
}










    




