using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services
{
    public class ContratoService : IContratoService
    {
        ContratoBS contratoBS;
        public ContratoService()
        {
            contratoBS = new ContratoBS();
        }

        public List<ContratoDto> GetContratoDto(int IdCliente, DateTime dataInicio, DateTime dataFim)
        {
            return contratoBS.GetContratoDto(IdCliente, dataInicio, dataFim);
        }

        public void SaveFaturamento(Contrato contrato)
        {
            contratoBS.UpdateFaturamento(contrato);
        }
    }
}
