﻿using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class ComissaoBS
    {
        IComissaoRepository dbComissao;
        public ComissaoBS()
        {
            dbComissao = new ComissaoRepository();
        }


        public List<Comissao> GetAll()
        {
            try
            {
                return dbComissao.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Comissaoes: {ex.Message}.");
            }
        }

        public Comissao Get(int idComissao)
        {
            try
            {
                return dbComissao.GetById(idComissao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Comissao: {ex.Message}.");
            }
        }

        public void Save(Comissao Comissao)
        {
            try
            {
                dbComissao.Add(Comissao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Comissao: {ex.Message}.");
            }
        }

        public void Update(Comissao Comissao)
        {
            try
            {
                dbComissao.Update(Comissao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Comissao: {ex.Message}.");
            }
        }

        public void Delete(int idComissao)
        {
            try
            {
                var Comissao = dbComissao.GetById(idComissao);
                dbComissao.Remove(Comissao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Comissao: {ex.Message}.");
            }
        }
    }
}