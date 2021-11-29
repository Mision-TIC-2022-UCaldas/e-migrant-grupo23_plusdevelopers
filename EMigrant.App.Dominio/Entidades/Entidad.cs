using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMigrant.App.Dominio.Entidades
{
    public class Entidad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La razón social es necesaria.")]
        [StringLength(50, ErrorMessage = "No puede tener más de 50 caracteres.")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El nit es necesario.")]
        [StringLength(15, ErrorMessage = "No puede tener más de 15 caracteres.")]
        public string Nit { get; set; }
        [Required(ErrorMessage = "La dirección es necesaria.")]
        [StringLength(30, ErrorMessage = "No puede tener más de 30 caracteres.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "La ciudad es necesaria.")]
        [StringLength(30, ErrorMessage = "No puede tener más de 30 caracteres.")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El teléfono es necesario.")]
        [StringLength(20, ErrorMessage = "No puede tener más de 20 caracteres.")]
        public string Telefono { get; set; }
        [StringLength(50, ErrorMessage = "No puede tener más de 50 caracteres.")]
        public string CorreoElectronico { get; set; }
        [StringLength(50, ErrorMessage = "No puede tener más de 50 caracteres.")]
        public string PaginaWeb { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un sector.")]
        public int SectorId { get; set; }
        public virtual Sector Sector { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un tipo de servicio.")]
        public int TipoServicioId { get; set; }
        public virtual TipoServicio TipoServicio { get; set; }
    }
}