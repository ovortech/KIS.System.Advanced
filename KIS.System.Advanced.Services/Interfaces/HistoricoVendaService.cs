using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public class HistoricoVendaService : IHistoricoVendaService
    {
        HistoricoVendaBS _historicoVendaBS;
        public HistoricoVendaService()
        {
            _historicoVendaBS = new HistoricoVendaBS();
        }

        public List<ItemPedidoDto> HistoricoVendaDetalheDto(int IdPedido)
        {
            return _historicoVendaBS.GetHistoricoVendaItensPedidoDto(IdPedido);
        }

        public List<HistoricoVendaDto> HistoricoVendaDto(int idVendedor, DateTime dataInicio, DateTime dataFim)
        {
            return _historicoVendaBS.GetHistoricoVendaDtos(idVendedor, dataInicio, dataFim);
        }
    }
}
