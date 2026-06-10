using CasosDeUso.DTOs.DTOsEquipo.DTOsOcular;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUEquipo.ICUOcular
{
    public interface ICUAltaOcular
    {
        void Ejecutar(DTOOcular dtoAltaOcular);
    }
}
