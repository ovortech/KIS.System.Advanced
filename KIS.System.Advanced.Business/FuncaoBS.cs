using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class FuncaoBS
    {
        #region class
        IFuncaoRepository dbFuncao;
        public FuncaoBS()
        {
            dbFuncao = new FuncaoRepository();
        }


        public List<Funcao> GetAll()
        {
            try
            {
                return dbFuncao.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Funcaoes: {ex.Message}.");
            }
        }

        public List<Funcao> GetAllActive()
        {
            try
            {
                return dbFuncao.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Funcaoes: {ex.Message}.");
            }
        }
        public List<Funcao> GetAllInactive()
        {
            try
            {
                return dbFuncao.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Funcaoes: {ex.Message}.");
            }
        }

        public Funcao Get(int idFuncao)
        {
            try
            {
                return dbFuncao.GetById(idFuncao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Funcao: {ex.Message}.");
            }
        }

        public void Save(Funcao Funcao)
        {
            try
            {
                dbFuncao.Add(Funcao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Funcao: {ex.Message}.");
            }
        }

        public void Update(Funcao Funcao)
        {
            try
            {
                dbFuncao.Update(Funcao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Funcao: {ex.Message}.");
            }
        }

        public void Delete(int idFuncao)
        {
            try
            {
                var Funcao = dbFuncao.GetById(idFuncao);
                dbFuncao.Remove(Funcao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Funcao: {ex.Message}.");
            }
        }
        #endregion
    }
}
