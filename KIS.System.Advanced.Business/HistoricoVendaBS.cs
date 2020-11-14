﻿using KIS.System.Advanced.Domain.Dto;
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

        public List<HistoricoVendaDto> GetHistoricoVendaDtos(int idVendedor, DateTime dataInicio, DateTime dataFim)
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

        public bool CancelarPedido(int IdPedido)
        {
            return true;
        }

    }
}
