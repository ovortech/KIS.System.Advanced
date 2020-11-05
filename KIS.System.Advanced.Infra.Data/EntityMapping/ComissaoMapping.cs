using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class ComissaoMapping : EntityTypeConfiguration<Comissao>
    {
        public ComissaoMapping()
        {
            ToTable("COMISSAO");
            Property(e => e.ID_ITEM_PEDIDO).IsRequired();
            Property(e => e.VALOR_COMPRA_COMISSAO).IsRequired();
            Property(e => e.VALOR_LUCRO_COMISSAO).IsRequired();
            Property(e => e.PERCENTUAL_COMISSAO).IsRequired();
            Property(e => e.ATIVO).IsRequired();
        }
    }
}
