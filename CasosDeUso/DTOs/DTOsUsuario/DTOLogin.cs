using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CasosDeUso.DTOs.DTOsUsuario
{
    public class DTOLogin
    {
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido.")]
        public string Email { get; set;  }
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]

        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres")]
        public string Pass { get; set; }
    }
}
