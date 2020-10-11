using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class TipoAcessoMapping : EntityTypeConfiguration<TipoAcesso>
    {
        public TipoAcessoMapping()
        {
            ToTable("TIPO_ACESSO");
            HasKey(e => e.ID_TIPO_ACESSO);
            Property(e => e.DESC_TIPO_ACESSO).HasMaxLength(50).IsRequired();
        }
    }
}
