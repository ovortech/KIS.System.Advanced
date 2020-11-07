using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IClienteService
    {
        List<Cliente> GetAll();
        void Save(Cliente cliente);
        Cliente Get(int idCliente);
        void Delete(int idCliente);
        void Update(Cliente cliente);
    }
}
