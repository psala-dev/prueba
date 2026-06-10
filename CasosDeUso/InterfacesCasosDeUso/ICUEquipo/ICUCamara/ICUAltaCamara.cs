using CasosDeUso.DTOs.DTOsEquipo.DTOCamara;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUEquipo.ICUCamara
{
    public interface ICUAltaCamara
    {
        void Ejecutar(DTOCamara dtoAltaCamara);
    }
}
