using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class ItemPedidoRepository : RepositoryBase<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ProjetoDataContext db = null) : base(db)
        {

        }

        public List<ItemPedido> GetAllByOrderId(int orderId)
        {
            return Db.ItemPedidos.Where(x => x.ID_PEDIDO == orderId).ToList();
        }
    }
}
