using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Dto
{
    public class ContratoDto
    {
        public int IdContrato { get; set; }
        public int IdPedido { get; set; }
        public int IdVendedor { get; set; }
        public String NomeCliente { get; set; }
        public String NomeVendedor { get; set; }
        public String Observacao { get; set; }
        public DateTime DataVenda { get; set; }
        public Double TotalPedido { get; set; }
        public Boolean Faturado { get; set; }
        public DateTime? DataFaturamento { get; set; }
    }
}
