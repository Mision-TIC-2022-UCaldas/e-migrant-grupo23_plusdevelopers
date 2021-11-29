using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EMigrant.App.Dominio.Entidades;
using EMigrant.App.Persistencia.AppRepositorios;

namespace MyApp.Namespace
{
    public class CreateNovedadesModel : PageModel
    {
        private readonly RepositorioNovedad _repoNovedad;
        [BindProperty]
        public Novedad Novedad { get; set; }
        public CreateNovedadesModel(RepositorioNovedad _repoNovedad)
        {
            this._repoNovedad = _repoNovedad;
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
            Novedad.Estado = true;
            _repoNovedad.CrearNovedad(Novedad);
            return RedirectToPage("./List");
        }
    }
}
