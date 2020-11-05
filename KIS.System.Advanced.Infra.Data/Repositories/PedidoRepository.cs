using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public PedidoRepository() : base()
        {

        }
        public int GetNextOrderNumber()
        {
            return Db.Set<Pedido>()
                            .OrderByDescending(x => x.ID_PEDIDO)
                            .FirstOrDefault().ID_PEDIDO + 1;


        }
    
    }
}
