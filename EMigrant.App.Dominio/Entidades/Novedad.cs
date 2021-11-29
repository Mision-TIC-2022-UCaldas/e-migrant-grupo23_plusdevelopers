using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMigrant.App.Dominio.Entidades
{
    public class Novedad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La fecha es necesaria.")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Los días son necesarios.")]
        public int NumeroDias { get; set; }
        [Required(ErrorMessage = "El texto explicativo es necesario.")]
        [StringLength(100, ErrorMessage = "No puede tener más de 100 caracteres.")]
        public string TextoExplicativo { get; set; }
        public bool Estado { get; set; }
    }
}