using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class TipoPgBS
    {
        #region class
        ITipoPgRepository dbTipoPg;
        public TipoPgBS()
        {
            dbTipoPg = new TipoPgRepository();
        }

        public List<TipoPg> GetAll()
        {
            try
            {
                return dbTipoPg.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoPges: {ex.Message}.");
            }
        }

        public List<TipoPg> GetAllActive()
        {
            try
            {
                return dbTipoPg.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoPges: {ex.Message}.");
            }
        }

        public List<TipoPg> GetAllInactive()
        {
            try
            {
                return dbTipoPg.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoPges: {ex.Message}.");
            }
        }

        public TipoPg Get(int idTipoPg)
        {
            try
            {
                return dbTipoPg.GetById(idTipoPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoPg: {ex.Message}.");
            }
        }

        public void Save(TipoPg TipoPg)
        {
            try
            {
                dbTipoPg.Add(TipoPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar TipoPg: {ex.Message}.");
            }
        }

        public void Update(TipoPg TipoPg)
        {
            try
            {
                dbTipoPg.Update(TipoPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do TipoPg: {ex.Message}.");
            }
        }

        public void Delete(int idTipoPg)
        {
            try
            {
                var TipoPg = dbTipoPg.GetById(idTipoPg);
                dbTipoPg.Remove(TipoPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir TipoPg: {ex.Message}.");
            }
        }
        #endregion
    }
}
