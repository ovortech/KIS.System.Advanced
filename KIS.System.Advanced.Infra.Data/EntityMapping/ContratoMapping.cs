using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class ContratoMapping : EntityTypeConfiguration<Contrato>
    {
        public ContratoMapping()
        {
            ToTable("CONTRATO");
            HasKey(e => e.ID_CONTRATO);
            Property(e => e.ID_PEDIDO_CONTRATO).IsRequired();
            Property(e => e.ID_CLIENTE_CONTRATO).IsRequired();
            Property(e => e.FATURADO_CONTRATO).IsRequired();
            Property(e => e.ATIVO).IsRequired();
        }
    }
}
