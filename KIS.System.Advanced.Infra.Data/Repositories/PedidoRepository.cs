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

        public void SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento)
        {
            using (var trans = Db.Database.BeginTransaction())
            {
                try
                {
                    var pedidoSalvo = Db.Set<Pedido>().Add(pedido);
                    Db.SaveChanges();

                    var itemPedidoRepository = new ItemPedidoRepository(Db);
                    foreach (var item in itensPedido)
                    {
                        item.ID_PEDIDO = pedidoSalvo.ID_PEDIDO;
                        itemPedidoRepository.Add(item);
                    }

                    var formaPagamentoRepository = new FormaPgRepository(Db);
                    foreach (var item in formasPagamento)
                    {
                        item.ID_PEDIDO = pedidoSalvo.ID_PEDIDO;
                        formaPagamentoRepository.Add(item);
                    }

                    trans.Commit();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }
}
