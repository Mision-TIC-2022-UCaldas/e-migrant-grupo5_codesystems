using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Dominio;
using Hackaton.App.Persistencia;

namespace Hackaton.App.Frontend.Pages
{
    public class ListarMigrantesModel : PageModel
    {
        
        private readonly IRepositorioMigrantes repositorioMigrantes;
        public IEnumerable<Migrante> Migrantes {get;set;}

        public ListarMigrantesModel(IRepositorioMigrantes repositorioMigrantes)
        {
            this.repositorioMigrantes=repositorioMigrantes;
        }
        public void OnGet()
        {
            Migrantes=repositorioMigrantes.GetAllMigrante();
        }

    }
}
