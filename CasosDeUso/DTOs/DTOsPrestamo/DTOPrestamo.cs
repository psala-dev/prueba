using CasosDeUso.DTOs.DTOsEquipo;
using CasosDeUso.DTOs.DTOsUsuario;
using LogicaNegocio.EntidadesNegocio;
using LogicaNegocio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CasosDeUso.DTOs.DTOsPrestamo
{
    public class DTOPrestamo
    {
        [DisplayName("Fecha de Inicio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType("Date")]
        public DateTime FechaInicio { get; set; }
        [DisplayName("Fecha de Fin")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType("Date")]
        public DateTime FechaFin { get; set; }
       

        public int[] EquipoId { get; set; }
        [DisplayName("Socio")]
        public int SocioId { get; set; }
        public string TipoEstado { get; set; }

        [DisplayName("Equipos")]
        [Range(1, 3, ErrorMessage = "Debe seleccionar entre 1 y 3 equipos.")]
        public IEnumerable<DTOEquipoPrestamo> Equipos { get; set; } =
            new List<DTOEquipoPrestamo>();
        [DisplayName("Socios")]
        public IEnumerable<DTOSocioPrestamo> Socios { get; set; } =
            new List<DTOSocioPrestamo>();
    }
}
