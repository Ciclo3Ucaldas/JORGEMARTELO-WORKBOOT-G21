using System;
namespace TallerMecanica.App.Dominio

{
    public class Servicio : Vehiculo
    {
        public int Id_Servicio { get; set; }
        public string Tipo_de_servicio { get; set; }
        public string Fecha { get; set; }


    }
}