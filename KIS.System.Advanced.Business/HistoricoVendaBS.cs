using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Business
{
    public class HistoricoVendaBS
    {
        HistoricoVendaRepository historicoVendaRepository;
        public HistoricoVendaBS()
        {
            historicoVendaRepository = new HistoricoVendaRepository();
        }

        public List<HistoricoVendaDto> GetHistoricoVendaDtos(int? idVendedor, DateTime dataInicio, DateTime dataFim)
        {
            List<HistoricoVendaDto> historicoVendaDtos = new List<HistoricoVendaDto>();
            historicoVendaDtos = historicoVendaRepository.GetHistoricoVendaDtos(idVendedor, dataInicio, dataFim);
            return historicoVendaDtos;
        }

        public List<ItemPedidoDto> GetHistoricoVendaItensPedidoDto(int IdPedido)
        {
            List<ItemPedidoDto> itemsPedido = new List<ItemPedidoDto>();
            itemsPedido = historicoVendaRepository.GetHistoricoVendaItensPedidoDto(IdPedido);
            return itemsPedido;
        }
        public List<TipoCancelamento> GetAllTipoCancelamento()
        {
            List<TipoCancelamento> TipoCancelamentos = new List<TipoCancelamento>();
            TipoCancelamentos = new TipoCancelamentoRepository().GetAllAtivos().ToList();
            return TipoCancelamentos;
        }
        public bool CancelarPedido(PedidoCancelamento pedidoCancelamento)
        {
            try
            {
                PedidoCancelamentoBS pedidoCancelamentoBS = new PedidoCancelamentoBS();
                pedidoCancelamentoBS.Save(pedidoCancelamento);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
