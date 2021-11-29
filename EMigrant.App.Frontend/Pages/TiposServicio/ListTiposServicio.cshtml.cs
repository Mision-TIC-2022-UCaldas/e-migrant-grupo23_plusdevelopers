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
    public class ListTiposServicioModel : PageModel
    {
        private readonly RepositorioTipoServicio _repoTipoServicio;
        public IEnumerable<TipoServicio> TiposServicio { get; set; }

        public ListTiposServicioModel(RepositorioTipoServicio _repoTipoServicio){
            this._repoTipoServicio = _repoTipoServicio;
        }
        public void OnGet()
        {
            TiposServicio = _repoTipoServicio.ObtenerTodosLosTiposServicio();
        }
    }
}
