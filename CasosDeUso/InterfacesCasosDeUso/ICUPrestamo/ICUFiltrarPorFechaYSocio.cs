using CasosDeUso.DTOs.DTOsPrestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUPrestamo
{
    public interface ICUFiltrarPorFechaYSocio
    {
        IEnumerable<DTOPrestamo> Ejecutar(DTOListarPrestamo dtoListarPrestamo);
    }
}
