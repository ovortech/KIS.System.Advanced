﻿using KIS.System.Advanced.Business;
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
    public class PedidoService : IPedidoService
    {
        private readonly PedidoBS _pedidoBS;
        public PedidoService()
        {
            _pedidoBS = new PedidoBS();
        }

        public void Delete(int idPedido)
        {
            _pedidoBS.Delete(idPedido);
        }

        public Pedido Get(int idPedido)
        {
            return _pedidoBS.Get(idPedido);
        }

        public List<Pedido> GetAll()
        {
            return _pedidoBS.GetAll();
        }

        public void Save(Pedido pedido)
        {
            _pedidoBS.Save(pedido);

        }

        public void Update(Pedido produto)
        {
            _pedidoBS.Update(produto);

        }

        public int SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento, bool cancelar = false)
        {
            return _pedidoBS.SaveNewOrder(pedido, itensPedido, formasPagamento, cancelar);
        }

        public List<ItemPedidoDto> DetalhePedidoDto(int IdPedido)
        {
            return _pedidoBS.DetalhePedidoDto(IdPedido);
        }
    }
}
