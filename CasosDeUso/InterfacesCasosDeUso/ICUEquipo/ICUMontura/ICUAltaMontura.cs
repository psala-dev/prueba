using CasosDeUso.DTOs.DTOsEquipo.DTOMontura;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUEquipo.ICUMontura
{
    public interface ICUAltaMontura
    {
        void Ejecutar(DTOMontura dtoAltaMontura);
    }
}
