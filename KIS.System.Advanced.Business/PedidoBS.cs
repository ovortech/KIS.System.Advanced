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

        public int GetNextOrderNumber()
        {
            try
            {
                return dbPedido.GetNextOrderNumber();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o próximo número de Pedido: {ex.Message}.");
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
