using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class TipoDespesaBS
    {
        #region class
        ITipoDespesaRepository dbTipoDespesa;
        public TipoDespesaBS()
        {
            dbTipoDespesa = new TipoDespesaRepository();
        }

        public List<TipoDespesa> GetAll()
        {
            try
            {
                return dbTipoDespesa.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoDespesas: {ex.Message}.");
            }
        }

        public List<TipoDespesa> GetAllActive()
        {
            try
            {
                return dbTipoDespesa.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoDespesas: {ex.Message}.");
            }
        }

        public List<TipoDespesa> GetAllInactive()
        {
            try
            {
                return dbTipoDespesa.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoDespesas: {ex.Message}.");
            }
        }

        public TipoDespesa Get(int idTipoDespesa)
        {
            try
            {
                return dbTipoDespesa.GetById(idTipoDespesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoDespesa: {ex.Message}.");
            }
        }

        public void Save(TipoDespesa TipoDespesa)
        {
            try
            {
                dbTipoDespesa.Add(TipoDespesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar TipoDespesa: {ex.Message}.");
            }
        }

        public void Update(TipoDespesa TipoDespesa)
        {
            try
            {
                dbTipoDespesa.Update(TipoDespesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do TipoDespesa: {ex.Message}.");
            }
        }

        public void Delete(int idTipoDespesa)
        {
            try
            {
                var TipoDespesa = dbTipoDespesa.GetById(idTipoDespesa);
                dbTipoDespesa.Remove(TipoDespesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir TipoDespesa: {ex.Message}.");
            }
        }
        #endregion
    }
}
