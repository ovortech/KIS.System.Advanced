using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IContratoService
    {
        List<ContratoDto> GetContratoDto(int IdCliente, DateTime dataInicio, DateTime dataFim);
        void SaveFaturamento(Contrato contrato);
    }
}
