using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class TipoCancelamentoBS
    {
        #region class
        ITipoCancelamentoRepository dbTipoCancelamento;
        public TipoCancelamentoBS()
        {
            dbTipoCancelamento = new TipoCancelamentoRepository();
        }

        public List<TipoCancelamento> GetAll()
        {
            try
            {
                return dbTipoCancelamento.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoCancelamentoes: {ex.Message}.");
            }
        }

        public List<TipoCancelamento> GetAllActive()
        {
            try
            {
                return dbTipoCancelamento.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoCancelamentoes: {ex.Message}.");
            }
        }
        public List<TipoCancelamento> GetAllInactive()
        {
            try
            {
                return dbTipoCancelamento.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoCancelamentoes: {ex.Message}.");
            }
        }

        public TipoCancelamento Get(int idTipoCancelamento)
        {
            try
            {
                return dbTipoCancelamento.GetById(idTipoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoCancelamento: {ex.Message}.");
            }
        }

        public void Save(TipoCancelamento TipoCancelamento)
        {
            try
            {
                dbTipoCancelamento.Add(TipoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar TipoCancelamento: {ex.Message}.");
            }
        }

        public void Update(TipoCancelamento TipoCancelamento)
        {
            try
            {
                dbTipoCancelamento.Update(TipoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do TipoCancelamento: {ex.Message}.");
            }
        }

        public void Delete(int idTipoCancelamento)
        {
            try
            {
                var TipoCancelamento = dbTipoCancelamento.GetById(idTipoCancelamento);
                dbTipoCancelamento.Remove(TipoCancelamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir TipoCancelamento: {ex.Message}.");
            }
        }
        #endregion
    }
}
