using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class TipoPgMapping : EntityTypeConfiguration<TipoPg>
    {
        public TipoPgMapping()
        {
            ToTable("TIPO_PG");
            HasKey(e => e.ID_TIPO_PG);
            Property(e => e.NOME_PG).HasMaxLength(50).IsRequired();
        }
    }
}
