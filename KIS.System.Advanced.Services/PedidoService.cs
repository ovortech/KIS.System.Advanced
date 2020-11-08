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
    public class PedidoService : IPedidoService
    {
        private readonly PedidoBS _pedidoBS;
        public PedidoService()
        {
            _pedidoBS = new PedidoBS();
        }

        public void Delete(int idPedido)
        {
            _pedidoBS.Delete(idPedido);
        }

        public Pedido Get(int idPedido)
        {
            return _pedidoBS.Get(idPedido);
        }

        public List<Pedido> GetAll()
        {
            return _pedidoBS.GetAll();
        }

        //public int GetNextOrderNumber()
        //{
        //    return _pedidoBS.GetNextOrderNumber();
        //}

        public void Save(Pedido pedido)
        {
            _pedidoBS.Save(pedido);

        }

        public void Update(Pedido produto)
        {
            _pedidoBS.Update(produto);

        }
    }
}
