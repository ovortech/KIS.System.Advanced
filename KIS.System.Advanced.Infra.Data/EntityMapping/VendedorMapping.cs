using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class VendedorMapping : EntityTypeConfiguration<Vendedor>
    {
        public VendedorMapping()
    {
        ToTable("VENDEDOR");
        HasKey(e => e.ID_VENDEDOR);
        Property(e => e.NOME_VENDEDOR).HasMaxLength(250).IsRequired();
        Property(e => e.ATIVO).IsRequired();
        }
}
}
