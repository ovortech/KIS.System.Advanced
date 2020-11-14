using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class FormaPgRepository : RepositoryBase<FormaPg>, IFormaPgRepository
    {
        public FormaPgRepository(ProjetoDataContext db = null) : base(db)
        {

        }

        public List<FormaPg> GetAllByOrderId(int orderId)
        {
            return Db.FormaPgs.Where(x => x.ID_PEDIDO == orderId).ToList();
        }
    }
}
