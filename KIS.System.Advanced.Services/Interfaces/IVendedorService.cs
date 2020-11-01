using KIS.System.Advanced.Domain.Entities;
using System.Collections.Generic;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IVendedorService
    {
        List<Vendedor> GetAll();
        void Save(Vendedor vendedor);
        Vendedor Get(int idvendedor);
        void Delete(int idvendedor);
        void Update(Vendedor vendedor);
    }
}
