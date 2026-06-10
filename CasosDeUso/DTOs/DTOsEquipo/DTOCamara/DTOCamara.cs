using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CasosDeUso.DTOs.DTOsEquipo.DTOCamara
{
    public class DTOCamara : DTOEquipo
    {
        [DisplayName("Resolución")]
        [Required(ErrorMessage = "La resolución es obligatoria")]
        public double Res { get; set; }
        [Required(ErrorMessage = "El pixel es obligatorio")]
        public double Pixel { get; set; }
        public string Sensor { get; set; }
        [DisplayName("Tipo de sensor")]
        [Required(ErrorMessage = "El tipo de sensor es obligatorio")]
        public string[] TipoSensor { get; set; }
    }

}
