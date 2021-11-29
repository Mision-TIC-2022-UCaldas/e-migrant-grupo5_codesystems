using System;

namespace Hackaton.App.Dominio
{
    public class Entidad
    {
        public int id{get;set;}
        public String RazonSocial{get;set;}
        public String Nit{get;set;}
        public String Direccion{get;set;}
        public String Ciudad{get;set;}
        public String Telefono{get;set;}
        public String Correo{get;set;}
        public String PaginaWeb{get;set;}
        public TipoSector Sector{get;set;}
        public TipoServicios TipoServicio{get;set;}
    }
}