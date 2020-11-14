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
    public class ItemPedidoService : IItemPedidoService
    {
        private readonly ItemPedidoBS _itemPedidoBS;

        public ItemPedidoService()
        {
            _itemPedidoBS = new ItemPedidoBS();
        }

        public List<ItemPedido> GetAllByOrderId(int orderId)
        {
            var itensPedido = _itemPedidoBS.GetAllByOrderId(orderId);
            return itensPedido;
        }
    }
}
