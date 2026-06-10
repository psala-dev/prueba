using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CasosDeUso.DTOs.DTOsEquipo
{
    public class DTOEquipo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        [DisplayName("Cantidad disponible")]
        public int CantDisponible { get; set; }
    }
}
