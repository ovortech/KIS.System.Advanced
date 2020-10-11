using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class ItemPedidoRepository : RepositoryBase<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository() : base()
        {

        }
    
    }
}
