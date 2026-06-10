using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CasosDeUso.DTOs.DTOsUsuario
{
    public class DTOListarSocio
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        [Phone(ErrorMessage = "Debe ingresar un teléfono válido")]
        public string Tel { get; set; }
        //[Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ingresar un email válido")]
        public string Email { get; set; }
        public string User { get; set; }
       }
}
