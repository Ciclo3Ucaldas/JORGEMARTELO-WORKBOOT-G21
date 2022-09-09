using System.Collections.Generic;
using TallerMecanica.App.Dominio;

namespace TallerMecanica.App.Persistencia

{
  public interface InterfazRepositorioPersona
  {
    IEnumerable <Persona> GetAllPersona();

    Persona AddPersona (Persona persona);

    Persona UpdatePersona (Persona persona);

    void DeletePersona (int IdPersona);

    Persona GetPersona (int IdPersona);




  }
}