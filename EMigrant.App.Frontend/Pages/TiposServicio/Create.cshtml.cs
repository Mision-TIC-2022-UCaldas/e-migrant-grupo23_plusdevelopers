using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EMigrant.App.Dominio.Entidades;
using EMigrant.App.Persistencia.AppRepositorios;

namespace List.Pages.TiposServicio
{
    public class CreateModel : PageModel
    {
        private readonly RepositorioTipoServicio _repoTipoServicio;
        [BindProperty]
        public TipoServicio TipoServicio { get; set; }
        public CreateModel(RepositorioTipoServicio _repoTipoServicio)
        {
            this._repoTipoServicio = _repoTipoServicio;
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
            _repoTipoServicio.CrearTipoServicio(TipoServicio);
            return RedirectToPage("./ListTiposServicio");
        }
    }
}
