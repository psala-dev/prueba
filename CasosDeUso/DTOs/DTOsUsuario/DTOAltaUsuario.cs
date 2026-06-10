using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace CasosDeUso.DTOs.DTOsUsuario
{
    public class DTOAltaUsuario
    {
             
        public string Nombre { get; set; }
        public string Direccion { get; set; }
       [Phone(ErrorMessage = "Debe ingresar un teléfono válido")]
        public string Tel { get; set; }
        //[Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ingresar un email válido")]
        public string Email { get; set; }
        public string User { get; set; }
        [DisplayName("Contraseña")]
        public string Pass { get; set; }
        //public int RolId { get; set; } //guarda la propiedad, no es id es el value del rol que selecciono
        [DisplayName("Rol")]

        public string NombreRol { get; set; }


        public string[] Roles { get; set; }
    }
}
