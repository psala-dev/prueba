using CasosDeUso.DTOs.DTOsObservacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUObservacion
{
    public interface ICUAltaObservacion
    {
        int Ejecutar(DTOAltaObservacion dtoAltaObservacion);
    }
}
