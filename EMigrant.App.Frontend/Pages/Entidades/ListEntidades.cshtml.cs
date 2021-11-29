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
    public class ListModel : PageModel
    {
        private readonly RepositorioEntidad _repoEntidad;
        private readonly RepositorioSector _repoSector;
        private readonly RepositorioTipoServicio _repoTipoServicio;
        public IEnumerable<Entidad> Entidades { get; set; }

        public ListModel(RepositorioEntidad _repoEntidad, RepositorioSector _repoSector, RepositorioTipoServicio _repoTipoServicio)
        {
            this._repoEntidad = _repoEntidad;
            this._repoSector = _repoSector;
            this._repoTipoServicio = _repoTipoServicio;
        }
        public void OnGet()
        {
            Entidades = _repoEntidad.ObtenerTodasLasEntidades();
        }

        public String consultarSector(int idSector){

           return _repoSector.ObtenerSector(idSector).Nombre;
        }

        public String consultarTipoServicio(int idTipoServicio){

            return _repoTipoServicio.ObtenerTipoServicio(idTipoServicio).Nombre;
        }
    }
}
