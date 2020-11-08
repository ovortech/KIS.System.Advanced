using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteBS _clienteBS;
        public ClienteService()
        {
            _clienteBS = new ClienteBS();
        }

        public void Delete(int idCliente)
        {
            _clienteBS.Delete(idCliente);
        }

        public Cliente Get(int idCliente)
        {
            return _clienteBS.Get(idCliente);
        }

        public List<Cliente> GetAll()
        {
            return _clienteBS.GetAll();
        }

        public List<Cliente> GetAllActive()
        {
            return _clienteBS.GetAllActive();
        }

        public List<Cliente> GetAllInactive()
        {
            return _clienteBS.GetAllInativos();
        }

        public void Save(Cliente cliente)
        {
            _clienteBS.Save(cliente);
        }

        public void Update(Cliente cliente)
        {
            _clienteBS.Save(cliente);
        }
    }
}
