using CasosDeUso.DTOs.DTOsEquipo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUEquipo
{
    public interface ICUListarEquipos
    {
        IEnumerable<DTOListarEquipo> Ejecutar();
    }
}
