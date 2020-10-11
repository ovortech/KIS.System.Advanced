using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class PedidoCancelamentoMapping : EntityTypeConfiguration<PedidoCancelamento>
    {
        public PedidoCancelamentoMapping()
        {
            ToTable("PEDIDO_CANCELAMENTO");
            HasKey(e => e.ID_PEDIDO_CANCELAMENTO);
            Property(e => e.ID_PEDIDO).IsRequired(); // VERIFICAR TIPO
            Property(e => e.ID_TIPO_CANCELAMENTO).IsRequired(); // VERIFICAR TIPO
            Property(e => e.DESC_PEDIDO_CANCELAMENTO).HasMaxLength(50).IsRequired();
            Property(e => e.DATA_CANCELAMENTO).IsRequired(); // VERIFICAR TIPO
        }
    }
}
