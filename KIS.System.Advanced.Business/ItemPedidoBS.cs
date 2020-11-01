using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class ItemPedidoBS
    {
        #region class
        IItemPedidoRepository dbItemPedido;
        public ItemPedidoBS()
        {
            dbItemPedido = new ItemPedidoRepository();
        }


        public List<ItemPedido> GetAll()
        {
            try
            {
                return dbItemPedido.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar ItemPedidoes: {ex.Message}.");
            }
        }

        public ItemPedido Get(int idItemPedido)
        {
            try
            {
                return dbItemPedido.GetById(idItemPedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar ItemPedido: {ex.Message}.");
            }
        }

        public void Save(ItemPedido ItemPedido)
        {
            try
            {
                dbItemPedido.Add(ItemPedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar ItemPedido: {ex.Message}.");
            }
        }

        public void Update(ItemPedido ItemPedido)
        {
            try
            {
                dbItemPedido.Update(ItemPedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do ItemPedido: {ex.Message}.");
            }
        }

        public void Delete(int idItemPedido)
        {
            try
            {
                var ItemPedido = dbItemPedido.GetById(idItemPedido);
                dbItemPedido.Remove(ItemPedido);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir ItemPedido: {ex.Message}.");
            }
        }
        #endregion
    }
}
