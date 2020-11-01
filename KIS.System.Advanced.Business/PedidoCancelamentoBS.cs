using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;


namespace KIS.System.Advanced.Business
{
    public class PedidoCancelamentoBS
    {
        #region class
        IPedidoCancelamentoRepository dbPedidoCancelamento;
        public PedidoCancelamentoBS()
        {
            dbPedidoCancelamento = new PedidoCancelamentoRepository();
        }


        public List<PedidoCancelamento> GetAll()
        {
            try
            {
                return dbPedidoCancelamento.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar PedidoCancelamentoes: {ex.Message}.");
            }
        }

        public PedidoCancelamento Get(int idPedidoCancelamento)
        {
            try
            {
                return dbPedidoCancelamento.GetById(idPedidoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar PedidoCancelamento: {ex.Message}.");
            }
        }

        public void Save(PedidoCancelamento PedidoCancelamento)
        {
            try
            {
                dbPedidoCancelamento.Add(PedidoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar PedidoCancelamento: {ex.Message}.");
            }
        }

        public void Update(PedidoCancelamento PedidoCancelamento)
        {
            try
            {
                dbPedidoCancelamento.Update(PedidoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do PedidoCancelamento: {ex.Message}.");
            }
        }

        public void Delete(int idPedidoCancelamento)
        {
            try
            {
                var PedidoCancelamento = dbPedidoCancelamento.GetById(idPedidoCancelamento);
                dbPedidoCancelamento.Remove(PedidoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir PedidoCancelamento: {ex.Message}.");
            }
        }
        #endregion
    }
}
