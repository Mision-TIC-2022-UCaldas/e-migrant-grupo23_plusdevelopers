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
    public class CreateModel : PageModel
    {
        private readonly RepositorioEntidad _repoEntidad;
        private readonly RepositorioSector _repoSector;
        private readonly RepositorioTipoServicio _repoTipoServicio;
        [BindProperty]
        public Entidad Entidad { get; set; }
        public IEnumerable<Sector> Sectores { get; set; }
        public Sector Sector { get; set; }
        [Required(ErrorMessage = "El sector es necesario.")]
        [BindProperty]
        public int SectorId { get; set; }
        public IEnumerable<TipoServicio> TiposServicio { get; set; }
        public TipoServicio TipoServicio { get; set; }
        [Required(ErrorMessage = "El tipo servicio es necesario.")]
        [BindProperty]
        public int TipoServicioId { get; set; }

        public CreateModel(RepositorioEntidad _repoEntidad, RepositorioSector _repoSector, RepositorioTipoServicio _repoTipoServicio)
        {
            this._repoEntidad = _repoEntidad;
            this._repoSector = _repoSector;
            this._repoTipoServicio = _repoTipoServicio;
        }
        public IActionResult OnGet()
        {
            Entidad = new Entidad();
            Sector = new Sector();
            TipoServicio = new TipoServicio();
            Sectores = _repoSector.ObtenerTodosLosSectores();
            TiposServicio = _repoTipoServicio.ObtenerTodosLosTiposServicio();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Entidad.SectorId = SectorId;
                Entidad.TipoServicioId = TipoServicioId;
                _repoEntidad.CrearEntidad(Entidad);
                return RedirectToPage("./ListEntidades");
                
            }
            return OnGet();
            
        }
    }
}
