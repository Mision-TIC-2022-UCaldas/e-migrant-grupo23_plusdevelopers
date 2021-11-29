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
    public class DetailsEntidadModel : PageModel
    {
        private readonly RepositorioEntidad _repoEntidad;
        private readonly RepositorioSector _repoSector;
        private readonly RepositorioTipoServicio _repoTipoServicio;
        public Entidad Entidad {get; set;}
        public IEnumerable<Sector> Sectores { get; set; }
        public int SectorId { get; set; }
        public IEnumerable<TipoServicio> TiposServicio { get; set; }
        public int TipoServicioId { get; set; }

        public bool entidadEncontrada { get; set; }

        public DetailsEntidadModel(RepositorioEntidad _repoEntidad, RepositorioSector _repoSector, RepositorioTipoServicio _repoTipoServicio)
        {
            this._repoEntidad = _repoEntidad;
            this._repoSector = _repoSector;
            this._repoTipoServicio = _repoTipoServicio;
        }
        public IActionResult OnGet(int idEntidad)
        {
            Entidad = _repoEntidad.ObtenerEntidad(idEntidad);
            Sectores = _repoSector.ObtenerTodosLosSectores();
            TiposServicio = _repoTipoServicio.ObtenerTodosLosTiposServicio();
            if (Entidad == null)
            {
                return Page();
            }
            else
            {
                SectorId = Entidad.SectorId;
                TipoServicioId = Entidad.TipoServicioId;
                return Page();
            }
        }
        public Entidad ConsultarEntidad(int id){
            return _repoEntidad.ObtenerEntidad(id);
        }
    }
}