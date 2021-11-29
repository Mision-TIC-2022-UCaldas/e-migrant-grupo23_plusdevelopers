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
    public class ListNovedadesModel : PageModel
    {
        private readonly RepositorioNovedad _repoNovedad;
        public IEnumerable<Novedad> Novedades { get; set; }

        public ListNovedadesModel(RepositorioNovedad _repoNovedad){
            this._repoNovedad = _repoNovedad;
        }
        public void OnGet()
        {
            Novedades = _repoNovedad.ObtenerTodasLasNovedades();
        }
    }
}