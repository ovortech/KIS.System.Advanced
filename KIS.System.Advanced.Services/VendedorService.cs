using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace KIS.System.Advanced.Services
{
    public class VendedorService : IVendedorService
    {
        private readonly VendedorBS vendedorBS;
        public VendedorService()
        {
            vendedorBS = new VendedorBS();
        }

        public void Delete(int idvendedor)
        {
            vendedorBS.Delete(idvendedor);
        }

        public void Update(Vendedor vendedor)
        {
            vendedorBS.Update(vendedor);
        }

        public Vendedor Get(int idvendedor)
        {
            return vendedorBS.Get(idvendedor);
        }

        public List<Vendedor> GetAll()
        {
            return vendedorBS.GetAll();
        }

        public void Save(Vendedor vendedor)
        {
            vendedorBS.Save(vendedor);
        }

        public List<Vendedor> GetAllActive()
        {
            return vendedorBS.GetAllActive();
        }

        public List<Vendedor> GetAllInactive()
        {
            throw new NotImplementedException();
        }
    }
}
