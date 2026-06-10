using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CasosDeUso.DTOs.DTOsEquipo.DTOMontura
{
    public class DTOMontura: DTOEquipo
    {
        public double Carga { get; set; }
        [DisplayName("Computarizado")]
        public bool EsComputarizado { get; set; }
        public string Montura { get; set; }
        [DisplayName("Tipo de montura")]

        public string[] TipoMontura { get; set; }
    }
}
    

