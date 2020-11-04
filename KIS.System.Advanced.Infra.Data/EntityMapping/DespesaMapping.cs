using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class DespesaMapping : EntityTypeConfiguration<Despesa>
    {
        public DespesaMapping()
        {
            ToTable("DESPESA");
            HasKey(e => e.ID_DESPESA);
            Property(e => e.ID_TIPO_DESPESA).IsRequired();
            Property(e => e.DESC_DESPESA).HasMaxLength(50).IsRequired();
            Property(e => e.VALOR_DESPESA).IsRequired(); // Verificar
            Property(e => e.DATA_DESPESA).IsRequired(); // Verificar
            Property(e => e.ID_LOGIN_DESPESA).IsRequired(); // Verificar
            Property(e => e.ATIVO).IsRequired(); // Verificar
        }
    }
}
