using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class ContratoRepository : RepositoryBase<Contrato>, IContratoRepository
    {
        public ContratoRepository(ProjetoDataContext db = null) : base(db)
        {

        }

        public List<ContratoDto> GetContratoDto(int IdCliente, DateTime dataInicio, DateTime dataFim)
        {
            dataFim = dataFim.AddDays(1).AddSeconds(-1);
            List<ContratoDto> contratoDtos = new List<ContratoDto>();
            var result = from contrato in Db.Contratos
                         join pedido in Db.Pedidos on contrato.ID_PEDIDO_CONTRATO equals pedido.ID_PEDIDO
                         join vendedor in Db.Vendedores on pedido.ID_VENDEDOR equals vendedor.ID_VENDEDOR
                         join cliente in Db.Clientes on pedido.ID_CLIENTE equals cliente.ID_CLIENTE
                         join cancelado in Db.PedidoCancelamentos on pedido.ID_PEDIDO equals cancelado.ID_PEDIDO into gjCancelado
                         from subCancelado in gjCancelado.DefaultIfEmpty()
                         where pedido.ID_CLIENTE == IdCliente &&
                         (pedido.DATA_REG_PEDIDO >= dataInicio && pedido.DATA_REG_PEDIDO <= dataFim) &&
                         subCancelado == null
                         select new ContratoDto
                         {
                             IdContrato = contrato.ID_CONTRATO,
                             IdPedido = contrato.ID_PEDIDO_CONTRATO,
                             IdVendedor = pedido.ID_VENDEDOR,
                             NomeVendedor = vendedor.NOME_VENDEDOR,
                             NomeCliente = cliente.NOME_CLIENTE,
                             Observacao = pedido.OBS_PEDIDO,
                             DataVenda = pedido.DATA_REG_PEDIDO,
                             TotalPedido = pedido.TOTAL_PEDIDO,
                             Faturado = contrato.FATURADO_CONTRATO,
                             DataFaturamento = contrato.DATA_FATURAMENTO
                         };
            contratoDtos = result.ToList();
            return contratoDtos;
        }
        public void UpdateFaturamento(Contrato Contrato)
        {
            using (var tran = Db.Database.BeginTransaction())
            {
                try
                {


                    var contratoBase = GetById(Contrato.ID_CONTRATO);
                    contratoBase.FATURADO_CONTRATO = Contrato.FATURADO_CONTRATO;
                    contratoBase.DATA_FATURAMENTO = Contrato.DATA_FATURAMENTO;
                    Update(contratoBase);
                    PedidoRepository pedidoRepository = new PedidoRepository(Db);
                    pedidoRepository.UpdateFaturamento(Contrato.ID_PEDIDO_CONTRATO, Contrato.FATURADO_CONTRATO);
                    tran.Commit();

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception($"Erro ao atualizar os dados do Contrato: {ex.Message}.");
                }
            }
        }
    }
}
