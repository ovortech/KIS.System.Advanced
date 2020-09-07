using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("Usuario");
            HasKey(e => e.UsuarioId);
            Property(e => e.Nome).HasMaxLength(150).IsRequired();
            Property(e => e.Sexo).HasMaxLength(1).IsFixedLength().IsRequired();
            Property(e => e.Email).HasMaxLength(150).IsRequired();
            Property(e => e.Ativo).IsRequired();
            Property(e => e.CargoId).IsRequired();
        }
    }
}
