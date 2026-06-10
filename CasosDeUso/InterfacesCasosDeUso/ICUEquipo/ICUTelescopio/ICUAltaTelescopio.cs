using CasosDeUso.DTOs.DTOsEquipo.DTOsTelescopio;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUEquipo.ICUTelescopio
{
    public interface ICUAltaTelescopio
    {
        void Ejecutar(DTOTelescopio dtoAltaTelescopio);
    }
}
