﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaMariaSolution.Shared.Models
{
    public class ControlCalidadProductoTerminado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(500,ErrorMessage = "No puede exceder los 500 caracteres")]
        public string? AcciónTomada { get; set; }
        public int EmpleadoId { get; set; }
        public int TandaId { get; set; }
    }
}
