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

        public void SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento, bool cancelar = false)
        {
            using (var trans = Db.Database.BeginTransaction())
            {
                try
                {
                    if (cancelar)
                    {
                        var pedidoCanceladoRepository = new PedidoCancelamentoRepository(Db);
                        pedidoCanceladoRepository.Add(new PedidoCancelamento
                        {
                            ID_PEDIDO = pedido.ID_PEDIDO,
                            ID_TIPO_CANCELAMENTO = 1,
                            DESC_PEDIDO_CANCELAMENTO = $"Alteração do pedido {pedido.ID_PEDIDO}",
                            DATA_CANCELAMENTO = DateTime.Now
                        });
                    }

                    //pedido.ID_PEDIDO = 0;

                    pedido.FATURADO_PEDIDO = pedido.ID_CLIENTE == 1 ? true : false;
                    var pedidoSalvo = Add(pedido);

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

                    if (pedido.ID_CLIENTE != 1)
                    {
                        ContratoRepository contratoRepository = new ContratoRepository(Db);
                        contratoRepository.Add(new Contrato
                        {
                            ID_CLIENTE_CONTRATO = pedido.ID_CLIENTE,
                            ID_PEDIDO_CONTRATO = pedido.ID_PEDIDO,
                            FATURADO_CONTRATO = false,
                            ATIVO = true
                        });
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }
    }
}
