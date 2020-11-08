using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class TipoAcessoBS
    {
        #region class
        ITipoAcessoRepository dbTipoAcesso;
        public TipoAcessoBS()
        {
            dbTipoAcesso = new TipoAcessoRepository();
        }


        public List<TipoAcesso> GetAll()
        {
            try
            {
                return dbTipoAcesso.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoAcessoes: {ex.Message}.");
            }
        }
        public List<TipoAcesso> GetAllActive()
        {
            try
            {
                return dbTipoAcesso.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoAcessoes: {ex.Message}.");
            }
        }
        public List<TipoAcesso> GetAllInactive()
        {
            try
            {
                return dbTipoAcesso.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoAcessoes: {ex.Message}.");
            }
        }

        public TipoAcesso Get(int idTipoAcesso)
        {
            try
            {
                return dbTipoAcesso.GetById(idTipoAcesso);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar TipoAcesso: {ex.Message}.");
            }
        }

        public void Save(TipoAcesso TipoAcesso)
        {
            try
            {
                dbTipoAcesso.Add(TipoAcesso);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar TipoAcesso: {ex.Message}.");
            }
        }

        public void Update(TipoAcesso TipoAcesso)
        {
            try
            {
                dbTipoAcesso.Update(TipoAcesso);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do TipoAcesso: {ex.Message}.");
            }
        }

        public void Delete(int idTipoAcesso)
        {
            try
            {
                var TipoAcesso = dbTipoAcesso.GetById(idTipoAcesso);
                dbTipoAcesso.Remove(TipoAcesso);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir TipoAcesso: {ex.Message}.");
            }
        }
        #endregion
    }
}
