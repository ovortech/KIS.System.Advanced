using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class TipoDespesaMapping : EntityTypeConfiguration<TipoDespesa>
    {
        public TipoDespesaMapping()
        {
            ToTable("TIPO_DESPESA");
            HasKey(e => e.ID_TIPO_DESPESA);
            Property(e => e.NOME_TIPO_DESPESA).HasMaxLength(50).IsRequired();
        }
    }
}
