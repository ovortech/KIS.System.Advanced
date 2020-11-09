using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Dto
{
    public class ComissaoDto
    {
        public int IdComissao { get; set; }
        public int IdItemPedido { get; set; }
        public int IdVendedor { get; set; }
        public DateTime DataVenda { get; set; }
        public string TipoVenda { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double ValorVenda { get; set; }
        public double? ValorCustoUnitario { get; set; }        
        public double? PercComissao { get; set; }
        public bool? Pago { get; set; }
        public bool? Ativo { get; set; }
    }
}
