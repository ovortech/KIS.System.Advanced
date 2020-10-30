using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class FormaPgBS
    {
        #region class
        IFormaPgRepository dbFormaPg;
        public FormaPgBS()
        {
            dbFormaPg = new FormaPgRepository();
        }


        public List<FormaPg> GetAll()
        {
            try
            {
                return dbFormaPg.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar FormaPges: {ex.Message}.");
            }
        }

        public FormaPg Get(int idFormaPg)
        {
            try
            {
                return dbFormaPg.GetById(idFormaPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar FormaPg: {ex.Message}.");
            }
        }

        public void Save(FormaPg FormaPg)
        {
            try
            {
                dbFormaPg.Add(FormaPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar FormaPg: {ex.Message}.");
            }
        }

        public void Update(FormaPg FormaPg)
        {
            try
            {
                dbFormaPg.Update(FormaPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do FormaPg: {ex.Message}.");
            }
        }

        public void Delete(int idFormaPg)
        {
            try
            {
                var FormaPg = dbFormaPg.GetById(idFormaPg);
                dbFormaPg.Remove(FormaPg);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir FormaPg: {ex.Message}.");
            }
        }
        #endregion
    }
}
