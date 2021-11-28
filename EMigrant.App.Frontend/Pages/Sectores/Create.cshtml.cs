using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EMigrant.App.Dominio.Entidades;
using EMigrant.App.Persistencia.AppRepositorios;

namespace List.Pages.Sectores
{
    public class CreateModel : PageModel
    {
        private readonly RepositorioSector _repoSector;
        [BindProperty]
        public Sector Sector { get; set; }
        public CreateModel(RepositorioSector _repoSector)
        {
            this._repoSector = _repoSector;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repoSector.CrearSector(Sector);
            return RedirectToPage("./ListSectores");
        }
    }
}
