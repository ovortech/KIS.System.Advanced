using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class PedidoMapping : EntityTypeConfiguration<Pedido>
    {
        public PedidoMapping()
        {
            ToTable("Pedido");
            HasKey(e => e.ID_PEDIDO);
            Property(e => e.ID_USUARIO_PEDIDO).IsRequired();
            Property(e => e.TOTAL_PEDIDO).IsRequired();
            Property(e => e.OBS_PEDIDO).HasMaxLength(50).IsRequired();
            Property(e => e.DATA_REG_PEDIDO).IsRequired();
            Property(e => e.ID_CLIENTE).IsRequired();
            Property(e => e.FATURADO_PEDIDO).IsRequired();
        }
    }
}
