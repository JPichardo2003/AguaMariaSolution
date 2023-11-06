﻿using System.ComponentModel.DataAnnotations;

namespace AguaMariaSolution.Shared.Models
{
    public class ControlCalidadAguaDetalle
    {
        [Key]
        public int ControlCalidadAguaDetalleId { get; set; }

        public int ControlCalidadAguaId { get; set; }

        public int ParametroId { get; set; }

        public float Valor { get; set; }

        public bool Pasó { get; set; }
    }
}
