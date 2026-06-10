using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.DTOs.DTOsUsuario
{
    public class DTOLoginResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string Token { get; set; }
    }
}
