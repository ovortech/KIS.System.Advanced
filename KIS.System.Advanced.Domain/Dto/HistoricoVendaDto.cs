using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Dto
{
    public class HistoricoVendaDto
    {
        public int IdPedido { get; set; }
        public int IdVendedor { get; set; }
        public String NomeVendedor { get; set; }
        public String Observacao { get; set; }
        public DateTime DataVenda { get; set; }
        public double TotalPedido { get; set; }
        public Boolean Faturado { get; set; }
        public bool Cancelado { get; set; }
        public String DescricaoCancelamento { get; set; }
        public List<ItemPedidoDto> ItemsPedido { get; set; }
    }
}
