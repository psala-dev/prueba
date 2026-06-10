using CasosDeUso.DTOs.DTOsObjetoCeleste;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUObjetoCeleste
{
    public interface ICURankingObjetoCeleste
    {
        IEnumerable<DTORankingObjetoCeleste> Ejecutar();
    }
}
