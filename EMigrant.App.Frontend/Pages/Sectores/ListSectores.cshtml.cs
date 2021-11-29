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
    public class ListSectoresModel : PageModel
    {
        private readonly RepositorioSector _repoSector;
        public IEnumerable<Sector> Sectores { get; set; }

        public ListSectoresModel(RepositorioSector _repoSector){
            this._repoSector = _repoSector;
        }
        public void OnGet()
        {
            Sectores = _repoSector.ObtenerTodosLosSectores();
        }
    }
}