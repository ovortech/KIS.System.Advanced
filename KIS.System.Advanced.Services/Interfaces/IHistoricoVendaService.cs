using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IHistoricoVendaService
    {
        List<HistoricoVendaDto> HistoricoVendaDto(int? idVendedor, DateTime dataInicio, DateTime dataFim);
        List<ItemPedidoDto> HistoricoVendaDetalheDto(int IdPedido);
        bool CancelaPedido(PedidoCancelamento pedidoCancelamento);
        List<TipoCancelamento> GetAllTipoCancelamento();
    }
}
