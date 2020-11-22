using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;

namespace KIS.System.Advanced.Domain.Interfaces
{
    public interface IContratoRepository : IRepositoryBase<Contrato>
    {
        List<ContratoDto> GetContratoDto(int IdCliente, DateTime dataInicio, DateTime dataFim);
        void UpdateFaturamento(Contrato Contrato);
        
    }


}
