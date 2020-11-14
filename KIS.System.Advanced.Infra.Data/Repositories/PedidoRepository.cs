using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ProjetoDataContext db = null) : base(db)
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
