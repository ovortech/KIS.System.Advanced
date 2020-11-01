using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{    
    public class FuncaoMapping : EntityTypeConfiguration<Funcao>
    {
        public FuncaoMapping()
        {
            ToTable("FUNCAO");
            HasKey(e => e.ID_FUNCAO);
            Property(e => e.DESC_FUNCAO).HasMaxLength(50).IsRequired();
        }
    }
}
