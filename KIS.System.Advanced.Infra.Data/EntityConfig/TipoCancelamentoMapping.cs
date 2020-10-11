using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class TipoCancelamentoMapping : EntityTypeConfiguration<TipoCancelamento>
    {
        public TipoCancelamentoMapping()
        {
            ToTable("TIPO_CANCELAMENTO");
            HasKey(e => e.id_tipo_cancelamento);
            Property(e => e.desc_tipo_cancelamento).HasMaxLength(50).IsRequired();
        }
    }
}
