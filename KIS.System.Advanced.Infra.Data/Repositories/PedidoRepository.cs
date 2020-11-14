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

        public void SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento)
        {
            using (var trans = Db.Database.BeginTransaction())
            {
                try
                {
                    //salva o pedido
                    var pedidoSalvo = Db.Set<Pedido>().Add(pedido);
                    Db.SaveChanges();

                    //pega o id e salva os ites, forma pagamento, etc
                    foreach (var item in itensPedido)
                        item.ID_PEDIDO = pedidoSalvo.ID_PEDIDO;

                    foreach (var item in formasPagamento)
                        item.ID_PEDIDO = pedidoSalvo.ID_PEDIDO;

                    Db.Set<ItemPedido>().AddRange(itensPedido);
                    Db.SaveChanges();

                    Db.Set<FormaPg>().AddRange(formasPagamento);
                    Db.SaveChanges();

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
    }
}
