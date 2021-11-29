using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackaton.App.Dominio;

namespace Hackaton.App.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrantes {
        ///<summary>
        ///Referencia al contexto de migrantes
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor
        ///</summary>
        ///<param name="appContext"></param>//


    public RepositorioMigrante(AppContext appContext) => _appContext = appContext;
    public Migrante AddMigrantes(Migrante migrante) {
            var migrantesAdicionar = _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            return migrantesAdicionar.Entity;

        }

        void IRepositorioMigrantes.DeleteMigrantes(int id) {
            var migrantesEncontrado = _appContext.Migrantes.FirstOrDefault(n => n.id == id);
            if (migrantesEncontrado == null)
                return;
            _appContext.Migrantes.Remove(migrantesEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Migrante> GetAllMigrante() {
            return _appContext.Migrantes;
        }

        public Migrante GetMigrantes(int id) {
            return _appContext.Migrantes.FirstOrDefault(p => p.id == id);
        }

        public Migrante UpdateMigrantes(Migrante migrante) {
            var migrantesEncontrado = _appContext.Migrantes.FirstOrDefault(p => p.id == migrante.id);
            if (migrantesEncontrado != null) {

                migrantesEncontrado.id = migrante.id;
                migrantesEncontrado.Nombres = migrante.Nombres;
                migrantesEncontrado.Apellidos = migrante.Apellidos;
                migrantesEncontrado.TipoDocumento=migrante.TipoDocumento;
                migrantesEncontrado.NumeroDocumento = migrante.NumeroDocumento;
                migrantesEncontrado.PaisOrigen = migrante.PaisOrigen;
                migrantesEncontrado.FechaNacimiento = migrante.FechaNacimiento;
                migrantesEncontrado.Correo = migrante.Correo;
                migrantesEncontrado.NumeroTelefono = migrante.NumeroTelefono;
                migrantesEncontrado.Direccion = migrante.Direccion;
                migrantesEncontrado.Ciudad = migrante.Ciudad;
                migrantesEncontrado.SituacionLaboral = migrante.SituacionLaboral;

                _appContext.SaveChanges();

            }

            return migrantesEncontrado;
        } 
        
    }

}
