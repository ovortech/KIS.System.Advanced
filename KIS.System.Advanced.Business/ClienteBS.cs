using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class ClienteBS
    {
        #region class
        IClienteRepository dbCliente;
        public ClienteBS()
        {
            dbCliente = new ClienteRepository();
        }


        public List<Cliente> GetAll()
        {
            try
            {
                return dbCliente.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Clientees: {ex.Message}.");
            }
        }

        public Cliente Get(int idCliente)
        {
            try
            {
                return dbCliente.GetById(idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Cliente: {ex.Message}.");
            }
        }

        public void Save(Cliente Cliente)
        {
            try
            {
                dbCliente.Add(Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Cliente: {ex.Message}.");
            }
        }

        public void Update(Cliente Cliente)
        {
            try
            {
                dbCliente.Update(Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Cliente: {ex.Message}.");
            }
        }

        public void Delete(int idCliente)
        {
            try
            {
                var Cliente = dbCliente.GetById(idCliente);
                dbCliente.Remove(Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Cliente: {ex.Message}.");
            }
        } 
        #endregion
    }
}
