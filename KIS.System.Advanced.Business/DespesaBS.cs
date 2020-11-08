using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class DespesaBS
    {
        #region class
        IDespesaRepository dbDespesa;
        public DespesaBS()
        {
            dbDespesa = new DespesaRepository();
        }

        public List<Despesa> GetAll()
        {
            try
            {
                return dbDespesa.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Despesas: {ex.Message}.");
            }
        }
        public List<Despesa> GetAllActive()
        {
            try
            {
                return dbDespesa.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Despesas: {ex.Message}.");
            }
        }
        public List<Despesa> GetAllInactive()
        {
            try
            {
                return dbDespesa.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Despesas: {ex.Message}.");
            }
        }

        public Despesa Get(int idDespesa)
        {
            try
            {
                return dbDespesa.GetById(idDespesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Despesa: {ex.Message}.");
            }
        }

        public void Save(Despesa Despesa)
        {
            try
            {
                dbDespesa.Add(Despesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Despesa: {ex.Message}.");
            }
        }

        public void Update(Despesa Despesa)
        {
            try
            {
                dbDespesa.Update(Despesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Despesa: {ex.Message}.");
            }
        }

        public void Delete(int idDespesa)
        {
            try
            {
                var Despesa = dbDespesa.GetById(idDespesa);
                dbDespesa.Remove(Despesa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Despesa: {ex.Message}.");
            }
        }
        #endregion
    }
}
