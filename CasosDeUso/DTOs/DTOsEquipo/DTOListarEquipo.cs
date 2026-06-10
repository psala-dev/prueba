using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CasosDeUso.DTOs.DTOsEquipo
{
    public class DTOListarEquipo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        [DisplayName("Cantidad disponible")]
        public int CantDisponible { get; set; }
        [DisplayName("Tipo de Equipo")]
        public string TipoEquipo { get; set; } // acá va el discriminator
    }
}
