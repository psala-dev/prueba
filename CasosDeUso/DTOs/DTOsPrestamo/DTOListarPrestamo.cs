using CasosDeUso.DTOs.DTOsEquipo;
using CasosDeUso.DTOs.DTOsUsuario;
using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CasosDeUso.DTOs.DTOsPrestamo
{
    public class DTOListarPrestamo
    {
        public int IdSocio { get; set; }
        [DisplayName("Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType("Date")]
        public DateTime Fecha { get; set; }

      
}
}
