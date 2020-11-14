using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class ComissaoRepository : RepositoryBase<Comissao>, IComissaoRepository
    {
        public ComissaoRepository(ProjetoDataContext db = null) : base(db)
        {

        }

        public void Merge(Comissao comissao)
        {
            if (comissao.PAGO_COMISSAO)
                comissao.DATA_PAGAMENTO_COMISSAO = DateTime.Now;

            if (comissao.ID_COMISSAO == 0)              
                Add(comissao);
            else
                Update(comissao);
        }

        public List<ComissaoDto> GetDto(int idVendedor, DateTime dataInicio, DateTime dataFim)
        {
            dataFim = dataFim.AddDays(1).AddSeconds(-1);
            var comissoesDto = new List<ComissaoDto>();
            var result = from pedido in Db.Pedidos
                         join itemPedido in Db.ItemPedidos on pedido.ID_PEDIDO equals itemPedido.ID_PEDIDO
                         join produto in Db.Produtos on itemPedido.ID_PRODUTO equals produto.ID_PRODUTO
                         join comissao in Db.Comissaos on itemPedido.ID_ITEM_PEDIDO equals comissao.ID_ITEM_PEDIDO into gjComissao
                         from subComissao in gjComissao.DefaultIfEmpty()
                         where pedido.ID_VENDEDOR == idVendedor && pedido.DATA_REG_PEDIDO >= dataInicio && pedido.DATA_REG_PEDIDO <= dataFim
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
                    IdComissao = (item.comissao ?? new Comissao()).ID_COMISSAO,
                    IdItemPedido = item.itemPedido.ID_ITEM_PEDIDO,
                    DataVenda = item.pedido.DATA_REG_PEDIDO,
                    TipoVenda = item.produto.SERVICO_PRODUTO ? "Serviço" : "Produto",
                    NomeProduto = item.produto.NOME_PRODUTO,
                    Descricao = item.itemPedido.OBS_PRODUTO,
                    Quantidade = item.itemPedido.QTD_PEDIDO,
                    ValorVenda = item.itemPedido.VALOR_UN_PEDIDO,
                    ValorCustoUnitario = (item.comissao ?? new Comissao()).VALOR_CUSTO_COMISSAO,
                    //ValorLucro = item.ValorLucro,
                    PercComissao = (item.comissao ?? new Comissao()).PERCENTUAL_COMISSAO,
                    Pago = (item.comissao ?? new Comissao()).PAGO_COMISSAO,
                    Ativo = (item.comissao ?? new Comissao()).ATIVO,
                    DataPg = (item.comissao ?? new Comissao()).DATA_PAGAMENTO_COMISSAO
                });
            }
            return comissoesDto;
        }
    }
}
