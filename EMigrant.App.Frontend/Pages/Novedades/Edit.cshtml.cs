using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EMigrant.App.Dominio.Entidades;
using EMigrant.App.Persistencia.AppRepositorios;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Namespace
{
    public class EditNovedadesModel : PageModel
    {
        private readonly RepositorioNovedad _repoNovedad;
        [BindProperty]
        public Novedad Novedad { get; set; }
        public EditNovedadesModel(RepositorioNovedad _repoNovedad){
            
            this._repoNovedad = _repoNovedad;
        }
        public IActionResult OnGet(int idNovedad)
        {
            Novedad = _repoNovedad.ObtenerNovedad(idNovedad);
            if (Novedad == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(int idNovedad)
        {
            if (ModelState.IsValid)
            {
                Novedad = _repoNovedad.ActualizarNovedad(Novedad);
                return RedirectToPage("./List");
                
            }
            return OnGet(idNovedad);
        }
    }
}