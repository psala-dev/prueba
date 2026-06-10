using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CasosDeUso.DTOs.DTOsEquipo.DTOsTelescopio
{
    public class DTOTelescopio : DTOEquipo
    {
        public double Apertura { get; set; }
        [DisplayName("Relación focal")]
        [Range(1, int.MaxValue, ErrorMessage = "La relación focal debe ser un número positivo.")]
        public string RelacionFocal { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La distancia focal debe ser un número positivo.")]
        [DisplayName("Distancia focal")]
        public double DistanciaFocal { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El peso debe ser un número positivo.")]
        public double Peso { get; set; }
    }
}