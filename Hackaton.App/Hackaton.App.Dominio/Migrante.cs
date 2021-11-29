using System;

namespace Hackaton.App.Dominio
{
    public class Migrante
    {
        public int id{get;set;}
        public String Nombres{get;set;}
        public String Apellidos{get;set;}
        public TipoDocumento TipoDocumento{get;set;}
        public String NumeroDocumento{get;set;}
        public String PaisOrigen{get;set;}
        public String FechaNacimiento{get;set;}
        public String Correo{get;set;}        
        public String NumeroTelefono{get;set;}
        public String Direccion{get;set;}
        public String Ciudad{get;set;}
        public String SituacionLaboral{get;set;}
    }
}
