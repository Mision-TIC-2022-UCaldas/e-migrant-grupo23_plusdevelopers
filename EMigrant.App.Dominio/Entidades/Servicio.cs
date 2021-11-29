using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMigrant.App.Dominio.Entidades
{
    public class Servicio
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es necesario.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El máximo número de migrantes es necesario.")]
        public int MaximoNumeroMigrantes { get; set; }
        [Required(ErrorMessage = "La fecha inicio es necesaria.")]
        public DateTime FechaInicio { get; set; }
        [Required(ErrorMessage = "La fecha fin es necesaria.")]
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}