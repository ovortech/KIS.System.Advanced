using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class PedidoBS
    {
        #region class
        IPedidoRepository dbPedido;
        public PedidoBS()
        {
            dbPedido = new PedidoRepository();
        }


        public List<Pedido> GetAll()
        {
            try
            {
                return dbPedido.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Pedidoes: {ex.Message}.");
            }
        }

        public Pedido Get(int idPedido)
        {
            try
            {
                return dbPedido.GetById(idPedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Pedido: {ex.Message}.");
            }
        }

        public void Save(Pedido Pedido)
        {
            try
            {
                dbPedido.Add(Pedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Pedido: {ex.Message}.");
            }
        }

        public int SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento, bool cancelar = false)
        {
            try
            {
                #region Trata dados pedido

                pedido.DATA_REG_PEDIDO = DateTime.Now;

                foreach (var item in itensPedido)
                    pedido.TOTAL_PEDIDO += item.QTD_PEDIDO * (item.VALOR_UN_PEDIDO - item.DESCONTO_PEDIDO);

                #endregion

                return dbPedido.SaveNewOrder(pedido, itensPedido, formasPagamento, cancelar);

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Pedido: {ex.Message}.");
            }
        }

        public List<ItemPedidoDto> DetalhePedidoDto(int idPedido)
        {
            try
            {
                HistoricoVendaBS historicoVendaBS = new HistoricoVendaBS();
            return historicoVendaBS.GetHistoricoVendaItensPedidoDto(idPedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar os detalhes do Pedido: {ex.Message}.");
            }
        }

        public void Update(Pedido Pedido)
        {
            try
            {
                dbPedido.Update(Pedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Pedido: {ex.Message}.");
            }
        }

        public void UpdateFaturamento(int idPedido, bool faturado)
        {
            try
            {
                var pedido = dbPedido.GetById(idPedido);
                pedido.FATURADO_PEDIDO = faturado;
                dbPedido.Update(pedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar o Faturamento dos dados do Pedido: {ex.Message}.");
            }
        }


        public void Delete(int idPedido)
        {
            try
            {
                var Pedido = dbPedido.GetById(idPedido);
                dbPedido.Remove(Pedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Pedido: {ex.Message}.");
            }
        }
        #endregion
    }
}
