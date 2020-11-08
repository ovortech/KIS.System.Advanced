using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Business
{
    public class VendedorBS
    {
        IVendedorRepository dbVendedor;
        public VendedorBS()
        {
            dbVendedor = new VendedorRepository();
        }


        public List<Vendedor> GetAll()
        {
            try
            {
                return dbVendedor.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Vendedores: {ex.Message}.");
            }
        }

        public Vendedor Get(int idVendedor)
        {
            try
            {
                return dbVendedor.GetById(idVendedor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Vendedor: {ex.Message}.");
            }
        }

        public void Save(Vendedor Vendedor)
        {
            try
            {
                dbVendedor.Add(Vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao salvar Vendedor: {ex.Message}.");
            }
        }

        public void Update(Vendedor Vendedor)
        {
            try
            {
                dbVendedor.Update(Vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados do Vendedor: {ex.Message}.");
            }
        }

        public void Delete(int idVendedor)
        {
            try
            {
                var Vendedor = dbVendedor.GetById(idVendedor);
                dbVendedor.Remove(Vendedor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Vendedor: {ex.Message}.");
            }
        }

        public List<Vendedor> GetAllActive()
        {
            try
            {
                return dbVendedor.GetAllAtivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Vendedores: {ex.Message}.");
            }
        }

        public List<Vendedor> GetAllInactive()
        {
            try
            {
                return dbVendedor.GetAllInativos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao pesquisar Vendedores: {ex.Message}.");
            }
        }
    }
}
