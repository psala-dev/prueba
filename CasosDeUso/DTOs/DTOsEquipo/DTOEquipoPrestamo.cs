using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CasosDeUso.DTOs.DTOsEquipo
{
    public class DTOEquipoPrestamo
    {
        public int Id { get; set; }
        [DisplayName("Equipos")]
        public string TipoEquipo { get; set; } 
    }
}
