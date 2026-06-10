using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CasosDeUso.DTOs.DTOsObjetoCeleste
{
    public class DTORankingObjetoCeleste
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Precision(18, 2)]
        public decimal Magnitud { get; set; }
        public string Tipo { get; set; }
        [DisplayName("Cantidad de vistas")]
        public int Contador { get; set; }
    }
}
