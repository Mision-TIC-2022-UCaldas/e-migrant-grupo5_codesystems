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
    public class EdCrMigrantesModel : PageModel
    {
        private readonly IRepositorioMigrantes repositorioMigrantes;
        [BindProperty]
        public Migrante migrantes1 {get;set;}

        public EdCrMigrantesModel(IRepositorioMigrantes repositorioMigrantes){
            this.repositorioMigrantes = repositorioMigrantes;
        }
        public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
            {
                migrantes1 = repositorioMigrantes.GetMigrantes(id.Value);
            }
            else
            {
                migrantes1 = new Migrante();
            }

            if(migrantes1==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(migrantes1.id>0)
            {
                migrantes1 = repositorioMigrantes.UpdateMigrantes(migrantes1);
            }
            else
            {
                repositorioMigrantes.AddMigrantes(migrantes1);
            }
            return Page();
        }
    }
}
