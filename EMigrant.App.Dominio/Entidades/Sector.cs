using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMigrant.App.Dominio.Entidades
{
    public class Sector
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es necesario.")]
        [StringLength(40, ErrorMessage = "No puede tener más de 40 caracteres.")]
        public string Nombre { get; set; }
    }
}