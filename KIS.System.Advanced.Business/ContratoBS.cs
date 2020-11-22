using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class ContratoBS
    {
        #region class
        IContratoRepository dbContrato;
        public ContratoBS()
        {
            dbContrato = new ContratoRepository();
        }

        public List<Contrato> GetAll()
        {
            try
            {
                return dbContrato.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Contratoes: {ex.Message}.");
            }
        }
        public List<Contrato> GetAllActive()
        {
            try
            {
                return dbContrato.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Contratoes: {ex.Message}.");
            }
        }

        public List<ContratoDto> GetContratoDto(int IdCliente, DateTime dataInicio, DateTime dataFim)
        {

            try
            {
                return dbContrato.GetContratoDto(IdCliente, dataInicio, dataFim);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Contratoes: {ex.Message}.");
            }
        }

        public List<Contrato> GetAllInactive()
        {
            try
            {
                return dbContrato.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Contratoes: {ex.Message}.");
            }
        }
        public Contrato Get(int idContrato)
        {
            try
            {
                return dbContrato.GetById(idContrato);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Contrato: {ex.Message}.");
            }
        }

        public void Save(Contrato Contrato)
        {
            try
            {
                dbContrato.Add(Contrato);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Contrato: {ex.Message}.");
            }
        }

        public void Update(Contrato Contrato)
        {
            try
            {                
                dbContrato.Update(Contrato);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Contrato: {ex.Message}.");
            }
        }

        public void UpdateFaturamento(Contrato Contrato)
        {
            try
            {                
                dbContrato.UpdateFaturamento(Contrato);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Contrato: {ex.Message}.");
            }
        }

        public void Delete(int idContrato)
        {
            try
            {
                var Contrato = dbContrato.GetById(idContrato);
                dbContrato.Remove(Contrato);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Contrato: {ex.Message}.");
            }
        }
        #endregion
    }
}
