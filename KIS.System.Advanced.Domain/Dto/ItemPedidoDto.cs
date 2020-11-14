using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Dto
{
    public class ItemPedidoDto
    {
        public int IdPedido { get; set; }
        public int IdItemPedido { get; set; }
        public int IdProduto { get; set; }
        public String NomeProduto { get; set; }
        public String Descricao { get; set; }
        public int Quantidade { get; set; }
        public Double ValorUnitario { get; set; }
        public Double DescontoUnitario { get; set; }
        public Double Total { get; set; }
    }
}
