using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.DTOs.DTOsObservacion
{
    public class DTOAltaObservacion
    {
        public int PrestamoId { get; set; }
        public int[] Prestamos { get; set; }
        public int ObjetoCelesteId { get; set; }
        public int[] ObjetosCelestes { get; set; }
        public DateTime Fecha { get; set; }

    }
}
