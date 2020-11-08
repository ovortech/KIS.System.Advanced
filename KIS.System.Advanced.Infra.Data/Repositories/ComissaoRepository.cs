﻿using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class ComissaoRepository : RepositoryBase<Comissao>, IComissaoRepository
    {
        public ComissaoRepository() : base()
        {

        }

        public List<ComissaoDto> GetDto()
        {
            var comissoesDto = new List<ComissaoDto>();
            var result = from pedido in Db.Pedidos
                         join itemPedido in Db.ItemPedidos on pedido.ID_PEDIDO equals itemPedido.ID_PEDIDO
                         join produto in Db.Produtos on itemPedido.ID_PRODUTO equals produto.ID_PRODUTO
                         join comissao in Db.Comissaos on itemPedido.ID_ITEM_PEDIDO equals comissao.ID_ITEM_PEDIDO into gjComissao
                         from subComissao in gjComissao.DefaultIfEmpty()
                         select new
                         {
                             pedido = pedido,
                             itemPedido = itemPedido,
                             produto = produto,
                             comissao = subComissao
                         };
            foreach (var item in result)
            {
                comissoesDto.Add(new ComissaoDto
                {
                    IdItemPedido = item.itemPedido.ID_ITEM_PEDIDO,
                    DataVenda = item.pedido.DATA_REG_PEDIDO,
                    TipoVenda = item.produto.SERVICO_PRODUTO ? "Serviço" : "Produto",
                    NomeProduto = item.produto.NOME_PRODUTO,
                    Descricao = item.itemPedido.OBS_PRODUTO,
                    Quantidade = item.itemPedido.QTD_PEDIDO,
                    ValorVenda = item.itemPedido.VALOR_UN_PEDIDO,
                    ValorCustoUnitario = (item.comissao ?? new Comissao()).VALOR_LUCRO_COMISSAO,
                    //ValorLucro = item.ValorLucro,
                    PercComissao = (item.comissao ?? new Comissao()).PERCENTUAL_COMISSAO,
                    Pago = (item.comissao ?? new Comissao()).PAGO_COMISSAO,
                    Ativo = (item.comissao ?? new Comissao()).ATIVO
                });
            }
            return comissoesDto;
        }
    }
}
