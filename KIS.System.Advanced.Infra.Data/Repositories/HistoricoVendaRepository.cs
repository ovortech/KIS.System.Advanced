using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class HistoricoVendaRepository : RepositoryBase<ItemPedido>, IItemPedidoRepository
    {
        public HistoricoVendaRepository(ProjetoDataContext db = null) : base(db)
        {
        }

        public List<HistoricoVendaDto> GetHistoricoVendaDtos(int idVendedor, DateTime dataInicio, DateTime dataFim)
        {
            dataFim = dataFim.AddDays(1).AddSeconds(-1);
            var historicoVendaDtos = new List<HistoricoVendaDto>();
            historicoVendaDtos = (from pedido in Db.Pedidos
                                  join vendedor in Db.Vendedores on pedido.ID_VENDEDOR equals vendedor.ID_VENDEDOR
                                  //join itemPedido in Db.ItemPedidos on pedido.ID_PEDIDO equals itemPedido.ID_PEDIDO
                                  //join produto in Db.Produtos on itemPedido.ID_PRODUTO equals produto.ID_PRODUTO
                                  where pedido.ID_VENDEDOR == idVendedor && pedido.DATA_REG_PEDIDO >= dataInicio && pedido.DATA_REG_PEDIDO <= dataFim
                                  select new HistoricoVendaDto
                                  {
                                      IdPedido = pedido.ID_PEDIDO,
                                      IdVendedor = pedido.ID_VENDEDOR,
                                      NomeVendedor = vendedor.NOME_VENDEDOR,
                                      //ID_USUARIO_PEDIDO = pedido.ID_USUARIO_PEDIDO,
                                      Observacao = pedido.OBS_PEDIDO,
                                      DataVenda = pedido.DATA_REG_PEDIDO,
                                      TotalPedido = pedido.TOTAL_PEDIDO,
                                      //ID_CLIENTE = pedido.ID_CLIENTE,
                                      Faturado = pedido.FATURADO_PEDIDO,
                                  }).Distinct().ToList();

            var idPedidos = historicoVendaDtos.Select(x => x.IdPedido).ToList();
            var itemsPedido = (from itemPedido in Db.ItemPedidos
                               join produto in Db.Produtos on itemPedido.ID_PRODUTO equals produto.ID_PRODUTO
                               where idPedidos.Contains(itemPedido.ID_PEDIDO)
                               select new ItemPedidoDto
                               {
                                   IdPedido = itemPedido.ID_PEDIDO,
                                   IdItemPedido = itemPedido.ID_ITEM_PEDIDO,
                                   IdProduto = itemPedido.ID_PRODUTO,
                                   NomeProduto = produto.NOME_PRODUTO,
                                   Descricao = itemPedido.OBS_PRODUTO,
                                   Quantidade = itemPedido.QTD_PEDIDO,
                                   ValorUnitario = itemPedido.VALOR_UN_PEDIDO,
                                   DescontoUnitario = itemPedido.DESCONTO_PEDIDO,
                                   Total = (itemPedido.QTD_PEDIDO * (itemPedido.VALOR_UN_PEDIDO - itemPedido.DESCONTO_PEDIDO)),
                               }).ToList();

            foreach (var item in historicoVendaDtos)
            {
                item.ItemsPedido = new List<ItemPedidoDto>();
                item.ItemsPedido.AddRange(itemsPedido.Where(x => x.IdPedido == item.IdPedido));
            }
            return historicoVendaDtos;
        }

        private double SomaPedidos(ItemPedido itemPedido)
        {
            throw new NotImplementedException();
        }
    }
}