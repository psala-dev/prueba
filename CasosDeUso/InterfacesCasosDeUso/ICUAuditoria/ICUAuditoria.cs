using CasosDeUso.DTOs.DTOsAuditoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasosDeUso.InterfacesCasosDeUso.ICUAuditoria
{
    public interface ICUAuditoria
    {
        void Ejecutar(DTOAuditoria dtoAuditoria);
    }
}
